using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static BManEntities db;
        static DataAccessFactory()
        {
            db = new BManEntities();
        }
        public static IRepository<colony, int> colonyDataAcees()
        {
            return new colonyRepo(db);
        }
        public static IRepository<building, int> buildingDataAccess()
        {
            return new buildingRepo(db);
        }

        public static IRepository<flat, int> flatDataAccess()
        {
            return new flatRepo(db);
        }

        public static IRepository<flatNumber, int> FNDataAccess()
        {
            return new FNRepo(db);
        }

        public static IRepository<wasaBill, int> WBDataAccess()
        {
            return new WBRepo(db);
        }

        public static IRepository<currentBill, int> CBDataAccess()
        {
            return new CBRepo(db);
        }

        public static IRepository<flatRent, int> FRDataAccess()
        {
            return new FRRepo(db);
        }
        public static IRepository<employee, int> EDataAccess()
        {
            return new ERepo(db);
        }
        public static IRepository<subcription, int> subDataAccess()
        {
            return new subRepo(db);
        }

        public static IRepository<subUser, int> SUDataAccess()
        {
            return new SURepo(db);
        }
        public static IRepository<login, int> LDataAccess()
        {
            return new loginRepo(db);
        }
        public static IRepository<user, int> userDataAccess()
        {
            return new userRepo(db);
        }
    }
}
