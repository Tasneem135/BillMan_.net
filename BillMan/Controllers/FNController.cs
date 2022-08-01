using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BillMan.Controllers
{
    public class FNController : ApiController
    {
        [Route("api/FN/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return FNumberService.GetNames();
        }
        [Route("api/FN/All")]
        [HttpGet]
        public List<FNModel> GetAll()
        {
            return FNumberService.Get();
        }
        [Route("api/FN/Create")]
        [HttpPut]
        public void Add(FNModel s)
        {
            FNumberService.Add(s);
        }

        [Route("api/FN/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            FNumberService.Delete(id);
        }

        [Route("api/FN/edit")]
        [HttpPost]

        public void Edit(FNModel e)
        {
            FNumberService.Edit(e);
        }
    }
}
