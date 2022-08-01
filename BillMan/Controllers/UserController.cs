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
    public class UserController : ApiController
    {
        [Route("api/User/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return userService.GetNames();
        }
        [Route("api/User/All")]
        [HttpGet]
        public List<userModel> GetAll()
        {
            return userService.Get();
        }
        [Route("api/User/Create")]
        [HttpPut]
        public void Add(userModel s)
        {
            userService.Add(s);
        }

        [Route("api/User/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            userService.Delete(id);
        }

        [Route("api/User/edit")]
        [HttpPost]

        public void Edit(userModel e)
        {
            userService.Edit(e);
        }
    }
}
