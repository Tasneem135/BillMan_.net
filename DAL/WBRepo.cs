using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WBRepo : IRepository<wasaBill, int>
    {
        BManEntities db;
        public WBRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(wasaBill e)
        {
            db.wasaBills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.wasaBills.FirstOrDefault(e => e.id == id);
            db.wasaBills.Remove(s);
            db.SaveChanges();
        }

        public void Edit(wasaBill e)
        {
            var s = db.wasaBills.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<wasaBill> Get()
        {
            return db.wasaBills.ToList();
        }

        public wasaBill Get(int id)
        {
            return db.wasaBills.FirstOrDefault(e => e.id == id);
        }
    }
}
