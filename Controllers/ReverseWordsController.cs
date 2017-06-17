using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readify_api.Controllers
{
    [Route("api/ReverseWords")]
    [Produces("application/json")]
    public class ReverseWordsController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get(string sentence)
        {
            var reversedWords = string.Join(" ",
                  sentence.Split(' ')
                     .Select(x => new String(x.Reverse().ToArray())));
            return Json(reversedWords);
        }
    }
}
