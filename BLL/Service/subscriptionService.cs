using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Database;
using DAL.Repo;
using DAL;

namespace BLL.Service
{
    public class subscriptionService
    {
        public static List<subscriptionModel> Get()
        {

            var config = new MapperConfiguration
               (b =>
               {
                   b.CreateMap<subscription, subscriptionModel>();

               }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<subscriptionModel>>(DataAccessFactory.subscriptionDataAccess().Get());
            return data;
        }

        

        public static void Add(subscriptionModel s)
        {
            var config = new MapperConfiguration
               (b =>
               {
                   b.CreateMap<subscriptionModel, subscription>();

               }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<subscription>(s);
            DataAccessFactory.subscriptionDataAccess().Add(data);

        }

        public static void Edit(subscriptionModel s)
        {
            var config = new MapperConfiguration
                (b =>
                {
                    b.CreateMap<subscriptionModel, subscription>();
                }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<subscription>(s);
            DataAccessFactory.subscriptionDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            var config = new MapperConfiguration
                  (b =>
                  {
                      b.CreateMap<subscriptionModel, subscription>();
                  }
                  );
            var mapper = new Mapper(config);
            DataAccessFactory.subscriptionDataAccess().Delete(id);

        }

    }
}
