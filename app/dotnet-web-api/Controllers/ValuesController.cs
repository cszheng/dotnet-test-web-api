using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_web_api.Libraries;

namespace dotnet_web_api.Controllers {
    
    [Route("api/[controller]")]
    public class ValuesController : Controller {
        // GET api/values
        [HttpGet]
        public IEnumerable<int> Get() {
            //get instance and increment count
            Increment incInstance = Increment.getInstance();
            incInstance.addCount();
            int[] curCount = { incInstance.Count };
            Console.WriteLine(curCount[0]);
            return curCount;
        }
    }
}