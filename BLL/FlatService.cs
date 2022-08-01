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
    public class FlatService
    {
        public static List<FlatModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<colony, ColonyModel>();
                c.CreateMap<building, BuildingModel>();
                c.CreateMap<flat, FlatModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<FlatModel>>(DataAccessFactory.flatDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.flatDataAccess().Get().Select(e => e.flatRenterName).ToList();
            //var data = DataAccessFactory.flatDataAccess().Get().Select(e => e.flatNumber).ToList();
            return data;
        }

        public static void Add(FlatModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FlatModel, flat>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<flat>(s);
            DataAccessFactory.flatDataAccess().Add(data);
        }

        public static void Edit(FlatModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<FlatModel, flat>())).Map<flat>(s);
            DataAccessFactory.flatDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.flatDataAccess().Delete(id);
        }
    }
}
