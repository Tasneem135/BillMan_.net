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
    public class LoginController : ApiController
    {
        [Route("api/Login/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return LService.GetNames();
        }
        [Route("api/Login/All")]
        [HttpGet]
        public List<loginModel> GetAll()
        {
            return LService.Get();
        }
        [Route("api/Login/Create")]
        [HttpPut]
        public void Add(loginModel s)
        {
            LService.Add(s);
        }

        [Route("api/Login/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            LService.Delete(id);
        }

        [Route("api/Login/edit")]
        [HttpPost]

        public void Edit(loginModel e)
        {
            LService.Edit(e);
        }
    }
}
