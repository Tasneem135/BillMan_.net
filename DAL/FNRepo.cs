using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class FNRepo : IRepository<flatNumber, int>
    {
        BManEntities db;
    public FNRepo(BManEntities db)
    {
        this.db = db;
    }
        public void Add(flatNumber e)
        {
            db.flatNumbers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.flatNumbers.FirstOrDefault(e => e.id == id);
            db.flatNumbers.Remove(s);
            db.SaveChanges();
        }

        public void Edit(flatNumber e)
        {
            var s = db.flatNumbers.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<flatNumber> Get()
        {
            return db.flatNumbers.ToList();
        }

        public flatNumber Get(int id)
        {
            return db.flatNumbers.FirstOrDefault(e => e.id == id);
        }
    }
}
