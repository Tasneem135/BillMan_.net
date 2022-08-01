using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class userRepo : IRepository<user, int>
    {
        BManEntities db;
        public userRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(user e)
        {
            db.users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.users.FirstOrDefault(e => e.id == id);
            db.users.Remove(s);
            db.SaveChanges();
        }

        public void Edit(user e)
        {
            var s = db.users.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<user> Get()
        {
            return db.users.ToList();
        }

        public user Get(int id)
        {
            return db.users.FirstOrDefault(e => e.id == id);
        }
    }
}
