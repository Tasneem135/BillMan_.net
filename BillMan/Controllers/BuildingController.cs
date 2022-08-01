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
    public class BuildingController : ApiController
    {
        [Route("api/Building/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return BuildingService.GetNames();
        }
        [Route("api/Building/All")]
        [HttpGet]
        public List<BuildingModel> GetAll()
        {
            return BuildingService.Get();
        }
        [Route("api/Building/Create")]
        [HttpPut]
        public void Add(BuildingModel s)
        {
            BuildingService.Add(s);
        }

        [Route("api/Building/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            BuildingService.Delete(id);
        }

        [Route("api/Building/edit")]
        [HttpPost]

        public void Edit(BuildingModel e)
        {
            BuildingService.Edit(e);
        }
    }
}
