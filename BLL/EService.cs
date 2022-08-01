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
    public class EService
    {
        public static List<EModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<employee, EModel>();
               
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EModel>>(DataAccessFactory.EDataAccess().Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.EDataAccess().Get().Select(e => e.name).ToList();
            return data;
        }

        public static void Add(EModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EModel, employee>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(s);
            DataAccessFactory.EDataAccess().Add(data);
        }

        public static void Edit(EModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EModel, employee>())).Map<employee>(s);
            DataAccessFactory.EDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.EDataAccess().Delete(id);
        }
    }
}
