using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNetCoreAPI.Routing.Controllers
{
    [Route("[controller]/[action]")]
    public class BooksController : ControllerBase
    {
        string[] Products = { "Book1", "Book2", "Book3", "Book4", "Book5", "Book6" };
        [HttpGet]
        public IActionResult Items()
        {
            object result = Products;
            return Ok(result);
        }

        [Route("{id?}")]
        public IActionResult Items(int id)
        {         
            object result = Products;
            if (id != 0 && id < Products.Length)
                result = Products[id];
            else
                result = $"Max count of Books is {Products.Length - 1}";

            return Ok(result);
        }
    }
}
