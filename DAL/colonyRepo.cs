using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class colonyRepo : IRepository<colony, int>
    {
        BManEntities db;
        public colonyRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(colony e)
        {
            db.colonys.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var s = db.colonys.FirstOrDefault(e => e.id == id);
            db.colonys.Remove(s);
            db.SaveChanges();

        }

        public void Edit(colony e)
        {
            var s = db.colonys.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<colony> Get()
        {
            return db.colonys.ToList();

        }

        public colony Get(int id)
        {
            return db.colonys.FirstOrDefault(e => e.id == id);

        }
        
    }
}
