using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BillService.API.Controllers
{
    public class PublicServicesController : ApiController
    {
        [HttpGet]
        public List<string> LoadServices()
        {
            List<string> servicios = new List<string>()
            {
                "Agua",
                "Gas",
                "Energia"
            };

            return servicios;
        }
    }
}
