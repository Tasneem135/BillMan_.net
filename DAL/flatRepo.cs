using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class flatRepo : IRepository<flat, int>
    {
        BManEntities db;
        public flatRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(flat e)
        {
            db.flats.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var s = db.flats.FirstOrDefault(e => e.id == id);
            db.flats.Remove(s);
            db.SaveChanges();

        }

        public void Edit(flat e)
        {
            var s = db.flats.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<flat> Get()
        {
            return db.flats.ToList();

        }

        public flat Get(int id)
        {
            return db.flats.FirstOrDefault(e => e.id == id);

        }

        public building Gets(int id)
        {
            return db.buildings.FirstOrDefault(e => e.id == id);
        }

        
    }
}
