using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelService)  // Dependency İndencions  için bunu kullanıyoruz
        {
            _hotelService = hotelService;  //  Önceden new HotelManager();  şeklindeydi 
        }

        [HttpGet]  // Get meotodu  
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();

        }

        [HttpGet("{id}")]
        public Hotel Get(int id) {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost] // Otel ekleme islemi yapıyor
        public Hotel Post([FromBody] Hotel hotel) {  // Body kısmında bir otel bekliyor
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut] // Güncelleme islemi yapıyor
        public Hotel Put([FromBody] Hotel hotel)// otel id almak zorunda
        {
            return _hotelService.Update(hotel);
        }

        [HttpDelete("{id}")] // Silme islemi yapıyor.
        public void Delete(int id)
        {
             _hotelService.DeleteHotel(id);
        }



    }
}
