using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class RoomManagementBusinessLayer
    {
        private RoomManagementData_layer room = new RoomManagementData_layer();

        public List<RoomSchedules> rooms()
        {
            return room.rooms();
        }
    }
}
