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
    public class LService
    {
        public static List<loginModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<login, loginModel>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<loginModel>>(DataAccessFactory.LDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.LDataAccess().Get().Select(e => e.username).ToList();
            return data;
        }

        public static void Add(loginModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<loginModel, login>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<login>(s);
            DataAccessFactory.LDataAccess().Add(data);
        }

        public static void Edit(loginModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<loginModel, login>())).Map<login>(s);
            DataAccessFactory.LDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.LDataAccess().Delete(id);
        }
    }
}
