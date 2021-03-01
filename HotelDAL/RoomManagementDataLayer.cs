using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data;

namespace HotelDAL
{
   public class RoomManagementData_layer
    {
        DBHelper DB = new DBHelper();

        public List<RoomSchedules> rooms()
        {
            List<RoomSchedules> rs = new List<RoomSchedules>();

            string sql = "select RoomNumber, [Floor],t.Name,s.StatusName,t.Price from RoomSchedules join RoomTypeTable t on t.No=RoomType join RoomStatus s on s.No=RoomStatus where 1=1";

            DataTable dt = DB.GetTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                RoomSchedules schedules = new RoomSchedules
                {
                    RoomNumber=dr["RoomNumber"].ToString(),
                    Floor=dr["Floor"].ToString(),
                    RoomType =dr["Name"].ToString(),
                    RoomStatus=dr["StatusName"].ToString(),
                    Price=dr["Floor"].ToString()
                };
                rs.Add(schedules);
            }
            return rs;
        }
    }
}
