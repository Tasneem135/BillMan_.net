
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;

namespace BillMan.Controllers
{
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return EService.GetNames();
        }
        [Route("api/Employee/All")]
        [HttpGet]
        public List<EModel> GetAll()
        {
            return EService.Get();
        }
        [Route("api/Employee/Create")]
        [HttpPut]
        public void Add(EModel s)
        {
            EService.Add(s);
        }

        [Route("api/Employee/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            EService.Delete(id);
        }

        [Route("api/Employee/edit")]
        [HttpPost]

        public void Edit(EModel e)
        {
            EService.Edit(e);
        }
    }
}
