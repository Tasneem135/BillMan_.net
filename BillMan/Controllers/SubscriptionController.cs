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
    public class SubscriptionController : ApiController
    {
        [Route("api/Subscription/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return subService.GetNames();
        }
        [Route("api/Subscription/All")]
        [HttpGet]
        public List<subModel> GetAll()
        {
            return subService.Get();
        }
        [Route("api/Subscription/Create")]
        [HttpPut]
        public void Add(subModel s)
        {
            subService.Add(s);
        }

        [Route("api/Subscription/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            subService.Delete(id);
        }

        [Route("api/Subscription/edit")]
        [HttpPost]

        public void Edit(subModel e)
        {
            subService.Edit(e);
        }
    }
}
