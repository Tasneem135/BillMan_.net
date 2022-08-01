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
    public class WBController : ApiController
    {
        [Route("api/WB/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return WBService.GetNames();
        }
        [Route("api/WB/All")]
        [HttpGet]
        public List<WBModel> GetAll()
        {
            return WBService.Get();
        }
        [Route("api/WB/Create")]
        [HttpPut]
        public void Add(WBModel s)
        {
            WBService.Add(s);
        }

        [Route("api/WB/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            WBService.Delete(id);
        }

        [Route("api/WB/edit")]
        [HttpPost]

        public void Edit(WBModel e)
        {
            WBService.Edit(e);
        }
    }
}
