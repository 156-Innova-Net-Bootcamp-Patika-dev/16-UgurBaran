using BasicSample_Api.Model;
using DocumentFormat.OpenXml.Office.CustomUI;
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
    public class ToItemsController : ControllerBase
    {
        public List<ToItems> items = new List<ToItems>()
        {
            new ToItems { Id = 1, Name = "Erdi", Surname = "Demir"},
            new ToItems { Id = 2, Name = "Ugur", Surname = "Baran"},
            new ToItems { Id = 3, Name = "Kagan", Surname = "Fındık"}

        };
         //GET api/values
         [HttpGet]
        public ActionResult<IEnumerable<ToItems>> GetAllItems()
        {
            return items;

        }

        //GET api/values/3
        [HttpGet("{id}")]
        public ActionResult<ToItems> Get(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] ToItems value)
        {

        }

        // PUT api/values/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToItems value)
        {

        }

        //DELETE api/values/3
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    
    }

    }




