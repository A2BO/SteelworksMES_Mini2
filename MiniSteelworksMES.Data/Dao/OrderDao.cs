using MiniSteelworksMES.Data.Dao;
using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class OrderDao : SingleKeyDao<Order, int>
    {
        protected override Expression<Func<Order, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Order, bool>> IsKey(int key)
        {
            return x => x.OrderId == key;
        }

        public List<Order> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            select x;

                return query.ToList();
            }
        }

        public List<Order> GetByPK(string orderId)
        {
            orderId.Trim();

            if (orderId == "")
                return null;

            int id = Convert.ToInt32(orderId);

            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            where x.OrderId == id
                            select x;

                return query.ToList();
            }
        }

        public List<Order> GetBySellerName(string sellerName)
        {
            sellerName.Trim();

            if (sellerName == "")
                return null;

            using (var context = new MesEntities())
            {
                var query = from x in context.Orders
                            where x.SellerName == sellerName
                            select x;

                return query.ToList();
            }
        }

        public void UpdateOrder(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);
            int rscId = Convert.ToInt32(list[1]);

            using (var context = new MesEntities())
            {
                var result = context.Orders.SingleOrDefault(x => x.OrderId == id);

                if (result != null)
                {
                    result.OrderId = Convert.ToInt32(list[0]);
                    result.ResourceId = rscId;
                    result.Date = Convert.ToDateTime(list[2]);
                    result.EmployeeId = Convert.ToInt32(list[3]);
                    result.Quantity = Convert.ToInt32(list[4]);
                    result.SellerName = list[5];
                }

                context.SaveChanges();
            }


        }

        public void InsertOrder(string[] strArray)
        {
            // insert
            using (var context = new MesEntities())
            {
                var orders = context.Set<Order>();
                orders.Add(new Order
                {
                    OrderId = Convert.ToInt32(strArray[0]),
                    ResourceId = Convert.ToInt32(strArray[1]),
                    Date = Convert.ToDateTime(strArray[2]),
                    EmployeeId = Convert.ToInt32(strArray[3]),
                    Quantity = Convert.ToInt32(strArray[4]),
                    SellerName = strArray[5]
                });

                context.SaveChanges();
            }
        }

        public void Delete(string strOrderId)
        {
            using (var context = new MesEntities())
            {
                Order order = context.Orders.Find(Convert.ToInt32(strOrderId));
                context.Orders.Remove(order);
                context.SaveChanges();
            }

        }
    }
}
