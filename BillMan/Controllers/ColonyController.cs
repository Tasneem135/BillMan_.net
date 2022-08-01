using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BillMan.Controllers
{
    public class ColonyController : ApiController
    {
        [Route("api/Colony/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ColonyService.GetNames();
        }
        [Route("api/Colony/All")]
        [HttpGet]
        public List<ColonyModel> GetAll()
        {
            return ColonyService.Get();
        }
        [Route("api/Colony/Create")]
        [HttpPut]
        public void Add(ColonyModel s)
        {
            ColonyService.Add(s);
        }

        [Route("api/Colony/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            ColonyService.Delete(id);
        }

        [Route("api/Colony/edit")]
        [HttpPost]

        public void Edit(ColonyModel e)
        {
            ColonyService.Edit(e);
        }
    }
}
