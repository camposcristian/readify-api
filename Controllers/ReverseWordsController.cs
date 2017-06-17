using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readify_api.Controllers
{
    [Route("api/ReverseWords")]
    public class ReverseWordsController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get(string sentence)
        {
            var reversedWords = string.Join(" ",
                  sentence.Split(' ')
                     .Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
        }
    }
}
