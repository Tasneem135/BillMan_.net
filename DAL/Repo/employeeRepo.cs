using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class employeeRepo : IRepository<employee, int>
    {
        BManEntities db;
        public employeeRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(employee s)
        {
            db.employees.Add(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.employees.Find(id);
            bman.employees.Remove(ds);
            bman.SaveChanges();
        }

        public void Edit(employee s)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.employees.FirstOrDefault(es => es.id == s.id);
            bman.Entry(ds).CurrentValues.SetValues(s);
            bman.SaveChanges();
        }

        public employee Get(int id)
        {
            return db.employees.FirstOrDefault(s => s.id == id);
        }

        public List<employee> Get()
        {
            return db.employees.ToList();
        }
    }
}
