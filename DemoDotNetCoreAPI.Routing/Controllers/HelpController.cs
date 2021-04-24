using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNetCoreAPI.Routing.Controllers
{
    public class HelpController : ControllerBase
    {
        string[] AvailableAPIs = { "api/Books/items", "api/Books/item/{id}", "api/Products/items", "api/Products/item/{id}" };
        [Route("help1" , Name ="help")]
        //[HttpGet("help")] //This is also valid implementation
        public IActionResult Details() 
        {
            object result = AvailableAPIs;
            return Ok(result);
        }
    }
}
