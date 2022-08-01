using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class buildingRepo : IRepository<building, int>
    {
        BManEntities db;
        public buildingRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(building e)
        {
            db.buildings.Add(e);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            var s = db.buildings.FirstOrDefault(e => e.id == id);
            db.buildings.Remove(s);
            db.SaveChanges();

        }

        public void Edit(building e)
        {
            var s = db.buildings.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<building> Get()
        {
            return db.buildings.ToList();
        }

        public building Get(int id)
        {
            return db.buildings.FirstOrDefault(e => e.id == id);
        }
        



    }
}
