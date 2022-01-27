using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {



        private IHotelRepository _hotelRepository; // Constructor metod içinde new ledik

        public HotelManager(IHotelRepository hotelRepository)// Dependency İndencions geregi bu şekilde kullanmak dah dogru
        {
            _hotelRepository = hotelRepository;  // Önceden = new HotelRepository  olarak yazılmıştı 
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if (id > 0)
            {


                return _hotelRepository.GetHotelById(id);
            }
            throw new Exception("Id 1 den kücük olamaz");
        }

        public Hotel Update(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
