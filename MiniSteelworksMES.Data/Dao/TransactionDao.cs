﻿using EFLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data
{
    public class TransactionDao : TripleKeyDao<Transaction, int, DateTime, int>
    {
        private int rowsCountPerPage = 20;
        protected override Expression<Func<Transaction, bool>> IsKey(int key1, DateTime key2, int key3)
        {
            return x => x.ResourceId == key1 && x.Date == key2;
        }

       

        public List<Transaction> GetAllByPagingQuery(int showPage)
        {
            using (var context = DbContextCreator.Create())
            {
                int totalCount = (from x in context.Transactions
                             select x).Count();

                int nPageCount = 0;
                nPageCount = totalCount / rowsCountPerPage;
                if ( totalCount % rowsCountPerPage != 0)
                    nPageCount += 1;

                var query = (from x in context.Transactions
                            select x).OrderBy( x => x.Date).Skip((showPage-1) * rowsCountPerPage).Take(rowsCountPerPage);

                return query.ToList();
            }
        }

        public int GetPageCount(int skipCount)
        {
            using (var context = DbContextCreator.Create())
            {
                int totalCount = (from x in context.Transactions
                                  select x).Count();

                int nPageCount = 0;
                nPageCount = totalCount / skipCount;
                if (totalCount % skipCount != 0)
                    nPageCount += 1;

                return nPageCount;
            }
        }

        public List<Transaction> GetByDate(DateTimeOffset start, DateTimeOffset end)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Transactions
                            where x.Date >= start && x.Date <= end
                            select x;

                List<Transaction> list = query.ToList();
                
                return query.ToList();
            }
        }

        public void UpdateTransaction(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);
            DateTime datetime = Convert.ToDateTime(list[2]);
            int type = (list[5] == "출고") ? 0 : 1;

            using (var context = DbContextCreator.Create())
            {
                var result = context.Transactions.SingleOrDefault(x => x.ResourceId == id
                   && x.Date == datetime
                   && x.Type == type);

                if (result != null)
                {
                    result.ResourceId = Convert.ToInt32(list[0]);
                    result.SellerName = list[1];
                    result.Date = Convert.ToDateTime(list[2]);
                    //result.Origin = list[3];
                    result.EmployeeId = Convert.ToInt32(list[4]);
                    result.Type = (list[5] == "출고") ? 0 : 1;
                    result.ResourceWareHouseId = Convert.ToInt32(list[6]);
                }

                context.SaveChanges();
            }
        }

        public List<Transaction> GetByResourceId(int rscId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Transactions
                            where x.ResourceId == rscId
                            select x;

                List<Transaction> list = query.ToList();

                return query.ToList();
            }
        }

        public List<Transaction> GetByResourceIdAndDate(int rscId, DateTime start, DateTime end)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Transactions
                            where x.Date >= start && x.Date <= end && x.ResourceId == rscId
                            select x;

                List<Transaction> list = query.ToList();

                return query.ToList();
            }
        }

        public List<Transaction> Search()
        {
            using (MesEntities context = DbContextCreator.Create())
            {
                Dictionary<int, string> ResourCeategories = context.Resources.ToDictionary(
                    x => x.ResourceId,
                    x => x.Name);

                var query = from x in context.Transactions
                            select x;

                var list = query.ToList();
                foreach (var x in list)
                {
                    x.ResourceCategory = ResourCeategories[x.ResourceId];
                }

                return list;

                
            }
            
        }

        //public List<TransactionModel> GetModels()
        //{
        //    using (MesEntities context = (MesEntities)DbContextCreator.Create())
        //    {
        //        var query = (from x in context.Transactions
        //                     select x).GroupBy(x => x.ResourceId).Select(
        //            group => new
        //            {
        //                group.FirstOrDefault().ResourceId,
        //                Quantity = group.Sum(
        //                x => x.Quantity)
        //            });

        //        List<TransactionModel> list = new List<TransactionModel>();

        //        foreach (var item in query)
        //        {
        //            if (item != null)
        //                list.Add(new TransactionModel(item.ResourceId, item.Quantity));
        //        }

        //        foreach (var item in list)
        //        {
        //            Debug.WriteLine(item.ResourceId + " " + item.Quantity);
        //        }

        //        return list;
        //    }
        //}

        //public List<TransactionModel> GetModels()
        //{
        //    using (MesEntities context = (MesEntities)DbContextCreator.Create())
        //    {
        //        Dictionary<int, string> resourceNames = context.Resources.ToDictionary(x => x.ResourceId, x => x.Name);

        //        var query = from x in context.Transactions
        //                    group x by x.ResourceId into g
        //                    select g;

        //        List<TransactionModel> models = new List<TransactionModel>();
        //        foreach (var @group in query)
        //        {
        //            TransactionModel model = new TransactionModel(group.Key, group.Sum(x => x.Quantity));//key는 위에서 만든 g의 ResourceId
        //            model.ResourceName = resourceNames[model.ResourceId];

        //            models.Add(model);
        //        }

        //        return models;
        //    }
        //}

        public List<TransactionModel> GetModels()
        {
            using (MesEntities context = (MesEntities)DbContextCreator.Create())
            {
                Dictionary<int, string> resourceNames = context.Resources.ToDictionary(x => x.ResourceId, x => x.Name);
                //Dictionary<int, DateTime> period = context.Transactions.ToDictionary(x => x.ResourceId, x => x.Date);

                var query = from x in context.Transactions //Transaction 요소를 모두 가져와
                            group x by x.ResourceId into g //ResourceId별로 정렬
                            select g;

                List<TransactionModel> models = new List<TransactionModel>();

                foreach (var @group in query)
                {
                    TransactionModel model = new TransactionModel(group.Key, group.Sum(x => x.Quantity));//key는 위에서 만든 g의 ResourceId
                    model.ResourceName = resourceNames[model.ResourceId];
                    models.Add(model);
                }

                return models;
            }
        }

        public List<OriginModel> GetModels2()
        {
            using (MesEntities context = (MesEntities)DbContextCreator.Create())
            {
                Dictionary<int, string> originName = context.Origins.ToDictionary(x => x.OriginId, x => x.Name);
                Dictionary<int, double> longgitud = context.Origins.ToDictionary(x => x.OriginId, x => x.Longgitude_Member);
                Dictionary<int, double> latitude = context.Origins.ToDictionary(x => x.OriginId, x => x.Latitude_Member);

                var query = from x in context.Transactions //Transaction 요소를 모두 가져와
                            group x by x.OriginId into g //OriginId별로 정렬
                            select g;

                List < OriginModel > models = new List<OriginModel>();

                foreach (var @group in query)
                {
                    OriginModel model = new OriginModel(group.Key, group.Sum(x => x.Quantity));//key는 위에서 만든 g의 ResourceId
                    model.OriginName = originName[model.OriginId];
                    model.Longgitude = longgitud[model.OriginId];
                    model.Latitude = latitude[model.OriginId];
                    models.Add(model);
                }

                return models;
            }
        }
    }
}
