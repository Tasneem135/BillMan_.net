using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace BillMan.Controllers
{
    public class SubUserController : ApiController
    {

        [Route("api/SubUser/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return SUService.GetNumber();
        }
        [Route("api/SubUser/All")]
        [HttpGet]
        public List<SUModel> GetAll()
        {
            return SUService.Get();
        }
        [Route("api/SubUser/Create")]
        [HttpPut]
        public void Add(SUModel s)
        {
            SUService.Add(s);
        }

        [Route("api/SubUser/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            SUService.Delete(id);
        }

        [Route("api/SubUser/edit")]
        [HttpPost]

        public void Edit(SUModel e)
        {
            SUService.Edit(e);
        }
    }
}
