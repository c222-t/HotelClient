using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data;

namespace HotelDAL
{
    public class RestaurantDataLayer
    {
        DBHelper DB = new DBHelper();
        public List<RestaurantPhysicalLayer> layers()
        {
            List<RestaurantPhysicalLayer> restaurants = new List<RestaurantPhysicalLayer>();

            string sql = "select Path,CanteenName,Price from CanteenTable where 1=1";

            DataTable dt = DB.GetTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                RestaurantPhysicalLayer table = new RestaurantPhysicalLayer
                {
                    CanteenName = dr["CanteenName"].ToString(),
                    Price=(double)dr["Price"],
                    Path=dr["Path"].ToString()
                };
                restaurants.Add(table);
            }
            return restaurants;
        }
    }
}
