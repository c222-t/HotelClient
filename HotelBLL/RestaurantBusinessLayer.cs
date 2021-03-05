using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using HotelDAL;

namespace HotelBLL
{
    public class RestaurantBusinessLayer
    {
        private RestaurantDataLayer layer = new RestaurantDataLayer();

        public List<RestaurantPhysicalLayer> layers()
        {
            return layer.layers();
        }
    }
}
