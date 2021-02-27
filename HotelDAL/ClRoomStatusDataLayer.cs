using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class RoomStatusDataLayer
    {
        DBHelper dB = new DBHelper();
        public RoomSchedules Rooms(string roomNumber)
        {
            RoomSchedules room = null;
            string Sql = "select RoomNumber,[Floor],T.Name,R.StatusName from RoomSchedules S join RoomTypeTable T on S.RoomType=T.[No] join RoomStatus R on R.No= S.RoomStatus where S.RoomNumber = @RoomNumber";

            SqlParameter[] sp =
            {
                new SqlParameter("@RoomNumber",roomNumber)
            };
            SqlDataReader dr = dB.ExecuteReader(Sql, sp);
            if (dr.Read())
            {
                room = new RoomSchedules
                {
                    RoomNumber = dr["RoomNumber"].ToString(),
                    RoomType = dr["Name"].ToString(),
                    RoomStatus = dr["StatusName"].ToString(),
                    Floor = dr["Floor"].ToString()
                };
            }
            return room;
        }
    }
}

