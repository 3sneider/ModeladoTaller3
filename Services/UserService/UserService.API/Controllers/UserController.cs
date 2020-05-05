using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserService.API.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public Boolean validateUser(string user)
        {
            if (string.IsNullOrEmpty(user))
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
    }
}
