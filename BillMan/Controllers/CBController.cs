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
    public class CBController : ApiController
    {

        [Route("api/CB/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CBService.GetNames();
        }
        [Route("api/CB/All")]
        [HttpGet]
        public List<CBModel> GetAll()
        {
            return CBService.Get();
        }
        [Route("api/CB/Create")]
        [HttpPut]
        public void Add(CBModel s)
        {
            CBService.Add(s);
        }

        [Route("api/CB/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            CBService.Delete(id);
        }

        [Route("api/CB/edit")]
        [HttpPost]

        public void Edit(CBModel e)
        {
            CBService.Edit(e);
        }
    }
}
