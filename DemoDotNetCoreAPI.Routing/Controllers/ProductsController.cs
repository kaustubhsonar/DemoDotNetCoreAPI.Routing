using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoDotNetCoreAPI.Routing.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    public class ProductsController : ControllerBase
    {
        string[] Products = { "Item0","Item1", "Item2", "Item3", "Item4", "Item5", "Item6" };
        //[Route("~/")]// "~/" is added to override the routing specified at the top of the controller.
        public IActionResult Items()
        {            
            object result = Products;
            return Ok(result);
        }       
        
        public IActionResult Item(int id)
        {
            object result = Products;
            if (id != 0 && id < Products.Length)
                result = Products[id];
            else
                result = $"Max count of products is {Products.Length-1}";

            return Ok(result);
        }
    }
}
