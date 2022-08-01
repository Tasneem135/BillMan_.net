using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class loginRepo : IRepository<login, int>
    {
        BManEntities db;
        public loginRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(login e)
        {
            db.logins.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.logins.FirstOrDefault(e => e.id == id);
            db.logins.Remove(s);
            db.SaveChanges();
        }

        public void Edit(login e)
        {
            var s = db.logins.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<login> Get()
        {
            return db.logins.ToList();
        }

        public login Get(int id)
        {
            return db.logins.FirstOrDefault(e => e.id == id);
        }
    }
}
