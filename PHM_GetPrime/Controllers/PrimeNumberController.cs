using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PHM_GetPrime.Controllers
{
    public class PrimeNumberController : ApiController
    {
        public static int PrimeNumber;
        public PrimeNumberController()
        {
            PrimeNumber = 5;
        }

        [HttpGet]
        [Route("api/GetPrimeNo/{Index}")]
        public IHttpActionResult Get(int index)
        {
            //do stuff
            PrimeNumber = 7;
            return Ok(7);
        }

        

    }
}
