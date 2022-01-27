using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Add(hotel); // parametre olarak verilen oteli ekle
                hotelDbContext.SaveChanges();// Degisiklikleri kaydet
                return hotel;// Oteli döndür
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deleteHotel = GetHotelById(id);// Silinecek oteli buluyoruz
                hotelDbContext.Hotels.Remove(deleteHotel);// Oteli siliyoruz
                hotelDbContext.SaveChanges();// Degisiklikleri kaydediyoruz
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using (var hotelDbContext = new HotelDbContext()) {
                return hotelDbContext.Hotels.ToList();//Otelleri listeliyoruz
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Update(hotel); // parametre olarak verilen oteli güncelle
                hotelDbContext.SaveChanges();// Degisiklikleri  kaydediyoruz.
                return hotel;
            }
        }
    }
}
