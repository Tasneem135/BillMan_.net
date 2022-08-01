using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FNumberService
    {
        public static List<FNModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<flatNumber, FNModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<FNModel>>(DataAccessFactory.FNDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.FNDataAccess().Get().Select(e => e.flatRenterName).ToList();
            return data;
        }

        public static void Add(FNModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FNModel, flatNumber>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<flatNumber>(s);
            DataAccessFactory.FNDataAccess().Add(data);
        }

        public static void Edit(FNModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<FNModel, colony>())).Map<flatNumber>(s);
            DataAccessFactory.FNDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.FNDataAccess().Delete(id);
        }
    }
}
