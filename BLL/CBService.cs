using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class CBService
    {
        public static List<CBModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<currentBill, CBModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CBModel>>(DataAccessFactory.CBDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.CBDataAccess().Get().Select(e => e.flatNumber).ToList();
            return data;
        }

        public static void Add(CBModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CBModel, currentBill>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<currentBill>(s);
            DataAccessFactory.CBDataAccess().Add(data);
        }

        public static void Edit(CBModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CBModel, currentBill>())).Map<currentBill>(s);
            DataAccessFactory.CBDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.CBDataAccess().Delete(id);
        }
    }
}
