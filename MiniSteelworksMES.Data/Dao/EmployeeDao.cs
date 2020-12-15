using EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteelworksMES.Data.Dao
{
    public class EmployeeDao : SingleKeyDao<Employee, int>
    {
        protected override Expression<Func<Employee, int>> KeySelector => throw new NotImplementedException();

        protected override Expression<Func<Employee, bool>> IsKey(int key)
        {
            return x => x.EmployeeId == key;
        }

        public bool VerifyIdPassword(string id, string passwd)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            where x.EmployeeId.ToString() == id && x.Password == passwd
                            select x;

                List<Employee> list = query.ToList();
                if ( list.Count() == 1 )
                    return true;

                return false;
            }
        }

        public string GetName(string id)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            where x.EmployeeId.ToString() == id
                            select x;

                List<Employee> list = query.ToList();
                if (list.Count() == 1)
                    return list[0].Name;

                return "";
            }
        }

        public List<Employee> GetAll()
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            select x;

                return query.ToList();
            }
        }

        public List<string> GetTeamNames()
        {
            using (var context = new MesEntities())
            {
                var query = (from x in context.Employees
                            select x.Team).Distinct();

                return query.ToList();
            }
        }

        public List<Employee> GetEmployeeByTeam(string teamName)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            where x.Team == teamName
                            select x;

                return query.ToList();
            }
        }

        public List<Employee> GetByPK(int employeeId)
        {
            using (var context = new MesEntities())
            {
                var query = from x in context.Employees
                            where x.EmployeeId == employeeId
                            select x;

                return query.ToList();
            }
        }

        public void UpdateEmployee(List<string> list)
        {
            int id = Convert.ToInt32(list[0]);

            using (var context = new MesEntities())
            {
                var result = context.Employees.SingleOrDefault(x => x.EmployeeId == id);

                if (result != null)
                {
                    result.EmployeeId = id;
                    result.Name = list[1];
                    result.Position = list[2];
                    result.BossId = Convert.ToInt32(list[3]);
                    result.Address = list[4];
                    result.PhoneNumber = list[5];
                    result.Team = list[6];
                    result.Password = list[7];
                }

                context.SaveChanges();
            }
        }

        public void InsertEmployee(List<string> list)
        {
            // insert
            using (var context = new MesEntities())
            {
                var orders = context.Set<Employee>();
                orders.Add(new Employee
                {
                    EmployeeId = Convert.ToInt32(list[0]),
                    Name = list[1],
                    Position = list[2],
                    BossId = Convert.ToInt32(list[3]),
                    Address = list[4],
                    PhoneNumber = list[5],
                    Team = list[6],
                    Password = list[7]
                });

                context.SaveChanges();
            }
        }
    }
}
