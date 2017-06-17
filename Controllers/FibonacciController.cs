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
        public int Get([FromQuery] int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
