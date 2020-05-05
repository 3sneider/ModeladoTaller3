using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessagesService.API.Controllers
{
    public class OKController : ApiController
    {
        [HttpGet]
        public string correctTransaction()
        {
            return "Transaccion Exitosa";
        }
    }
}
