using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class subRepo : IRepository<subcription, int>
    {
        BManEntities db;
        public subRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(subcription e)
        {
            db.subcriptions.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.subcriptions.FirstOrDefault(e => e.id == id);
            db.subcriptions.Remove(s);
            db.SaveChanges();
        }

        public void Edit(subcription e)
        {
            var s = db.subcriptions.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<subcription> Get()
        {
            return db.subcriptions.ToList();
        }

        public subcription Get(int id)
        {
            return db.subcriptions.FirstOrDefault(e => e.id == id);
        }
    }
}
