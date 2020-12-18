using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P2k7.Api.Controllers
{
    [RoutePrefix("Demo")]
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("Foo")]
        public string Foo()
        {
            return "Novi";
        }
    }
}
