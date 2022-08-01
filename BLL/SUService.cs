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
    public class SUService
    {
        public static List<SUModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<subUser, SUModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<SUModel>>(DataAccessFactory.SUDataAccess().Get());
            return data;

        }

        public static List<string> GetNumber()
        {
            var data = DataAccessFactory.SUDataAccess().Get().Select(e => e.mobile).ToList();
            return data;
        }

        public static void Add(SUModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SUModel, subUser>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<subUser>(s);
            DataAccessFactory.SUDataAccess().Add(data);
        }

        public static void Edit(SUModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<SUModel, subUser>())).Map<subUser>(s);
            DataAccessFactory.SUDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.SUDataAccess().Delete(id);
        }
    }
}
