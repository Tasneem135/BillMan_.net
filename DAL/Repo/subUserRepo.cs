using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    
    public class subUserRepo : IRepository<subUser, int>
    {

        BManEntities db;
        public subUserRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(subUser s)
        {
            db.subUsers.Add(s);
            db.SaveChanges();

        }

        public void Delete(int id)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.subUsers.Find(id);
            bman.subUsers.Remove(ds);
            bman.SaveChanges();
        }

        public void Edit(subUser s)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.subUsers.FirstOrDefault(es => es.id == s.id);
            bman.Entry(ds).CurrentValues.SetValues(s);
            bman.SaveChanges();

        }

        public subUser Get(int id)
        {
            return db.subUsers.FirstOrDefault(s => s.id == id);
        }

        public List<subUser> Get()
        {
            return db.subUsers.ToList();
        }

       /* public subUser Get(int id)
        {
            BManEntities bman = new BManEntities();
            var ds = bman.subUsers.Find(id);
            return db.subUsers.FirstOrDefault(s => s.id == id);


        }*/
    }

}
