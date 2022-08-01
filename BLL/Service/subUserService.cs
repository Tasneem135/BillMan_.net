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
    public class subUserService
    {
        public static List<subUserModel> Get()
        {

            var config = new MapperConfiguration
               (b =>
                {
                    b.CreateMap<subUser, subUserModel>();

                }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<subUserModel>>(DataAccessFactory.subUserDataAccess().Get());
            return data;
        }

        public static  List<int> Get(int id)
        {
            var data = DataAccessFactory.subUserDataAccess().Get().Select(s => s.id).ToList();
            return data;
        }

        public static void Add(subUserModel s)
        {
            var config = new MapperConfiguration
               (b =>
               {
                   b.CreateMap<subUserModel, subUser>();

               }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<subUser>(s);
            DataAccessFactory.subUserDataAccess().Add(data);

        }

        public static void Edit(subUserModel s)
        {
            var config = new MapperConfiguration
                (b =>
                 {
                     b.CreateMap<subUserModel, subUser>();
                 }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<subUser>(s);
            DataAccessFactory.subUserDataAccess().Edit(data);
        }

       public static void Delete(int id)
        {
            var config = new MapperConfiguration
                  (b =>
                  {
                      b.CreateMap<subUserModel, subUser>();
                  }
                  );
            var mapper = new Mapper(config);
            DataAccessFactory.subUserDataAccess().Delete(id);

        }
    }
}
