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
    public class subService
    {
        public static List<subModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<subcription, subModel>();
                
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<subModel>>(DataAccessFactory.subDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.subDataAccess().Get().Select(e => e.username).ToList();
            return data;
        }

        public static void Add(subModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<subModel, subcription>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<subcription>(s);
            DataAccessFactory.subDataAccess().Add(data);
        }

        public static void Edit(subModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<subModel, subcription>())).Map<subcription>(s);
            DataAccessFactory.subDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.subDataAccess().Delete(id);
        }
    }
}
