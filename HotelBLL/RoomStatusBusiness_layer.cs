using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class RoomStatusBusiness_layer
    {
        private RoomStatusDataLayer dataLayer = new RoomStatusDataLayer();

        public RoomSchedules rooms(string roomNumber)
        {
            return dataLayer.Rooms(roomNumber);
        }
    }
}
