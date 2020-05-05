using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaymentMethodsService.API.Controllers
{
    public class PaymentController : ApiController
    {
        [HttpGet]
        public List<string> LoadPaymentMethods()
        {
            List<string> methods = new List<string>()
            {
                "Tarjeta Debito",
                "Tarjeta Credito",
                "Efectivo",
                "PSE"
            };

            return methods;
        }

        [HttpGet]
        public bool ValidateBalance(string targetNumber)
        {
            if (string.IsNullOrEmpty(targetNumber))
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
