using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readify_api.Controllers
{
    [Route("api/TriangleType")]
    public class TriangleTypeController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get(int a, int b, int c)
        {
            int[] values = new int[3] { a, b, c };

            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Error";
            }
            if (!(a + b > c || a + c > b || b + c > a))
            {
                return "Error";
            }
            if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
            {
                return "Equilateral";
            }
            if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
            {
                return "Isosceles";
            }
            if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
            {
                return "Scalene";
            }
            else
            {
                return "Error";
            }
        }
    }
}
