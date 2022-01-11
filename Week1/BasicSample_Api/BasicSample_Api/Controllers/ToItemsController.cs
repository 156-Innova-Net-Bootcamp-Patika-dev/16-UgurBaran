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
            new ToItems { Id = 2, Name = "Ozge", Surname = "Acik"},
            new ToItems { Id = 3, Name = "Kagan", Surname = "Fındık"},
            new ToItems { Id = 4, Name = "Merve", Surname = "Bilgic"},
            new ToItems { Id = 4, Name = "Ugur", Surname = "Baran"}

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

        //Ekleme işlemi yapılıyor.
        [HttpPost]
        public IActionResult Post([FromBody] ToItems product)
        {
            items.Add(product);
            return StatusCode(StatusCodes.Status201Created);
        }
        


        // UPDATE  işlemi yapılıyor
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ToItems item)
        {
            var currentItem = items.Where(x => x.Id == id).FirstOrDefault();

            if (currentItem != null)
            {
                currentItem.Name = item.Name;
                currentItem.Surname = item.Surname;


                return Ok();
            }
            else
            {
                return NotFound("Kisi bulunamadı!");
            }
        }

        //Todo
        [HttpDelete("{id}")]
        public ActionResult<ToItems> Delete(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item ! == null)
            {
                items.Remove(item);
            }
            
            return NotFound($"Aradığınız kişi bulunamadı");
            
        }

       
    }

    }




