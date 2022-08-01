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
    public class employeeService
    {
        public static List<employeeModel> Get()
        {

            var config = new MapperConfiguration
               (b =>
               {
                   b.CreateMap<employee, employeeModel>();

               }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<employeeModel>>(DataAccessFactory.employeeDataAccess().Get());
            return data;
        }


        public static void Add(employeeModel s)
        {
            var config = new MapperConfiguration
               (b =>
               {
                   b.CreateMap<employeeModel, employee>();

               }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(s);
            DataAccessFactory.employeeDataAccess().Add(data);

        }

        public static void Edit(employeeModel s)
        {
            var config = new MapperConfiguration
                (b =>
                {
                    b.CreateMap<employeeModel, employee>();
                }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<employee>(s);
            DataAccessFactory.employeeDataAccess().Edit(data);
        }

        public static void Delete(int id)
        {
            var config = new MapperConfiguration
                  (b =>
                  {
                      b.CreateMap<employeeModel, employee>();
                  }
                  );
            var mapper = new Mapper(config);
            DataAccessFactory.employeeDataAccess().Delete(id);

        }
    }
}
