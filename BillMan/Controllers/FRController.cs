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
    public class FRController : ApiController
    {

        [Route("api/FR/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return FRService.GetNames();
        }
        [Route("api/FR/All")]
        [HttpGet]
        public List<FRModel> GetAll()
        {
            return FRService.Get();
        }
        [Route("api/FR/Create")]
        [HttpPut]
        public void Add(FRModel s)
        {
            FRService.Add(s);
        }

        [Route("api/FR/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            FRService.Delete(id);
        }

        [Route("api/FR/edit")]
        [HttpPost]

        public void Edit(FRModel e)
        {
            FRService.Edit(e);
        }
    }
}
