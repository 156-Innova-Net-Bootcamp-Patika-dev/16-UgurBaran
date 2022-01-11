using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicSample_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "Value1", "Value2", "Value3" };

        //}

        //GET api/values/3
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "The value is " + id;
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        //DELETE api/values/3
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}
