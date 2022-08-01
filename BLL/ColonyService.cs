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
    public class ColonyService
    {
        public static List<ColonyModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<colony, ColonyModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ColonyModel>>(DataAccessFactory.colonyDataAcees().Get());
            return data;
      
        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.colonyDataAcees().Get().Select(e => e.colonyName).ToList();
            return data;
        }

        public static void Add(ColonyModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ColonyModel, colony>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<colony>(s);
            DataAccessFactory.colonyDataAcees().Add(data);
        }

        public static void Edit(ColonyModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ColonyModel, colony>())).Map<colony>(s);
            DataAccessFactory.colonyDataAcees().Edit(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.colonyDataAcees().Delete(id);
        }

        

    }
}
