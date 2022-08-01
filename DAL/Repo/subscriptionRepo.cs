using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class subscriptionRepo : IRepository<subscription, int>
    {
        BManEntities db;
        public subscriptionRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(subscription s)
        {
            db.subscriptions.Add(s);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.subscriptions.Find(id);
            bman.subscriptions.Remove(ds);
            bman.SaveChanges();

        }

        public void Edit(subscription s)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.subscriptions.FirstOrDefault(es => es.id == s.id);
            bman.Entry(ds).CurrentValues.SetValues(s);
            bman.SaveChanges();


        }

        public subscription Get(int id)
        {
            return db.subscriptions.FirstOrDefault(s => s.id == id);
        }

        public List<subscription> Get()
        {
            return db.subscriptions.ToList();
        }
    }
}
