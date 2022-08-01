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
    public class userService
    {
        public static List<userModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<user, userModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<userModel>>(DataAccessFactory.userDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.userDataAccess().Get().Select(e => e.name).ToList();
            return data;
        }

        public static void Add(userModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<userModel, user>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<user>(s);
            DataAccessFactory.userDataAccess().Add(data);
        }

        public static void Edit(userModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<userModel, user>())).Map<user>(s);
            DataAccessFactory.userDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.userDataAccess().Delete(id);
        }
    }
}
