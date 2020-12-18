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
    public class TeamDao : SingleKeyDao<Team, int>
    {
        protected override Expression<Func<Team, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Team, bool>> IsKey(int key)
        {
            return x => x.TeamId == key;
        }

        public List<Team> GetAll()
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Teams
                            select x;

                return query.ToList();
            }
        }

        public List<TheModel> GetModel()
        {
            using (var context = DbContextCreator.Create())
            {
                List<Team> teams = context.Teams.ToList();

                var query = from x in context.Sales
                            where x.TeamId != null
                            group x by x.TeamId into g
                            select g;

                // 달성건수 추가
                List<TheModel> saleModels = new List<TheModel>();
                foreach (var g in query)
                {
                    TheModel model = new TheModel();
                    model.Type = "달성건수";
                    model.Count = g.Count();
                    model.Team = teams.Find(t => t.TeamId == g.Key.Value).Name;

                    saleModels.Add(model);
                }


                // 목표건수 추가
                List<TheModel> targetModels = new List<TheModel>();
                foreach (var saleModel in saleModels)
                {
                    Team team = teams.Find(t => t.Name == saleModel.Team);

                    if (team == null)
                        continue;

                    TheModel targetModel = new TheModel();
                    targetModel.Type = "목표건수";
                    targetModel.Team = team.Name;
                    targetModel.Count = team.Target ?? 0;

                    targetModels.Add(targetModel);
                }

                saleModels.AddRange(targetModels);

                return saleModels;
            }
        }
    }
}
