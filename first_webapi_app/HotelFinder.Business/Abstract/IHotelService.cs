using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotel();

        Hotel GetHotelById(int id);

        Hotel CreateHotel(Hotel hotel);

        Hotel updatedHotel(Hotel hotel);

        void DeleteHotel(int id);

    }
}
