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
        // test için değişkenler tanımlandı
        public List<ToItems> items = new List<ToItems>()
        {
            new ToItems { Id = 1, Name = "Erdi", Surname = "Demir"},
            new ToItems { Id = 2, Name = "Ugur", Surname = "Baran"},
            new ToItems { Id = 3, Name = "Kagan", Surname = "Fındık"}

        };
         //GETALL methodu 
         [HttpGet]
        public ActionResult<IEnumerable<ToItems>> GetAllItems()
        {
            return items;

        }

        //Id ye göre filtrelemek için
        [HttpGet("{id}")]
        public ActionResult<ToItems> Get(int id)
        {
            // verilen id ye göre listeyi tarar
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        //ToDo
        [HttpPost]
        public void Post([FromBody] ToItems value)
        {

        }

        // Todo
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToItems value)
        {

        }

        //Todo
        [HttpDelete("{id}")]
        public ActionResult<ToItems> Delete(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound($"Aradığınız kişi bulunamadı");
            }
            items.Remove(item);
            return item;
        }
    
    }

    }




