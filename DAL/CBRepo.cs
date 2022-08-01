using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CBRepo : IRepository<currentBill, int>
    {
        BManEntities db;
        public CBRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(currentBill e)
        {
            db.currentBills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.currentBills.FirstOrDefault(e => e.id == id);
            db.currentBills.Remove(s);
            db.SaveChanges();
        }

        public void Edit(currentBill e)
        {
            var s = db.currentBills.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<currentBill> Get()
        {
            return db.currentBills.ToList();
        }

        public currentBill Get(int id)
        {
            return db.currentBills.FirstOrDefault(e => e.id == id);
        }
    }
}
