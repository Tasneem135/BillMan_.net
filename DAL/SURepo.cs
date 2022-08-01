using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SURepo : IRepository<subUser, int>
    {
        BManEntities db;
        public SURepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(subUser e)
        {
            db.subUsers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.subUsers.FirstOrDefault(e => e.id == id);
            db.subUsers.Remove(s);
            db.SaveChanges();
        }

        public void Edit(subUser e)
        {
            var s = db.subUsers.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<subUser> Get()
        {
            return db.subUsers.ToList();
        }

        public subUser Get(int id)
        {
            return db.subUsers.FirstOrDefault(e => e.id == id);
        }
    }
}
