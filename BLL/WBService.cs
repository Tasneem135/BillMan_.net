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
    public class WBService
    {
        public static List<WBModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<wasaBill, WBModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<WBModel>>(DataAccessFactory.WBDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.WBDataAccess().Get().Select(e => e.flatNumber).ToList();
            return data;
        }

        public static void Add(WBModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<WBModel, wasaBill>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<wasaBill>(s);
            DataAccessFactory.WBDataAccess().Add(data);
        }

        public static void Edit(WBModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<WBModel, wasaBill>())).Map<wasaBill>(s);
            DataAccessFactory.WBDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.WBDataAccess().Delete(id);
        }
    }
}
