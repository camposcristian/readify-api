using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readify_api.Controllers
{
    [Route("api/Fibonacci")]
    public class FibonacciController : Controller
    {
        // GET api/values
        [HttpGet]
        [Produces("application/json")]
        public ActionResult Get([FromQuery] int? n)
        {
            if (n == null)
            {
                return BadRequest();
            }
            if (n > 92)
            {
                return BadRequest();
            }
            Int64 a = 0;
            Int64 b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                Int64 temp = a;
                a = b;
                b = temp + b;
            }
            return Ok(a);
        }
    }
}
