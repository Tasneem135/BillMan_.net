using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ERepo : IRepository<employee, int>
    {
        BManEntities db;
        public ERepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(employee e)
        {
            db.employees.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.employees.FirstOrDefault(e => e.id == id);
            db.employees.Remove(s);
            db.SaveChanges();
        }

        public void Edit(employee e)
        {
            var s = db.employees.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<employee> Get()
        {
            return db.employees.ToList();
        }

        public employee Get(int id)
        {
            return db.employees.FirstOrDefault(e => e.id == id);
        }
    }
}
