using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readify_api.Controllers
{
    [Route("api/Token")]
    [Produces("application/json")]
    public class TokenController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "\"3f774e03-084a-47de-9a55-d896b7fef2b3\"";
        }
    }
}
