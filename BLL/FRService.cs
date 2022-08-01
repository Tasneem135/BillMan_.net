using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL;
using DAL;

namespace BLL
{
   public  class FRService
    {
        public static List<FRModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<flatRent, FRModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<FRModel>>(DataAccessFactory.FRDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.FRDataAccess().Get().Select(e => e.flatNumber).ToList();
            return data;
        }

        public static void Add(FRModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FRModel, flatRent>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<flatRent>(s);
            DataAccessFactory.FRDataAccess().Add(data);
        }

        public static void Edit(FRModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<FRModel, flatRent>())).Map<flatRent>(s);
            DataAccessFactory.FRDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.FRDataAccess().Delete(id);
        }
    }
}
