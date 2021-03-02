using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class HotelServiceBusinessLayer
    {
        private HotelServiceDataLayer layer = new HotelServiceDataLayer();

        public List<CommodityTable> tables()
        {
            return layer.tables();
        }
    }
}
