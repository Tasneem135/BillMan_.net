using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FRRepo : IRepository<flatRent, int>
    {
        BManEntities db;
        public FRRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(flatRent e)
        {
            db.flatRents.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.flatRents.FirstOrDefault(e => e.id == id);
            db.flatRents.Remove(s);
            db.SaveChanges();
        }

        public void Edit(flatRent e)
        {
            var s = db.flatRents.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<flatRent> Get()
        {
            return db.flatRents.ToList();
        }

        public flatRent Get(int id)
        {
            return db.flatRents.FirstOrDefault(e => e.id == id);
        }
    }
}
