using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    /// <summary>
    /// 用户登录
    /// </summary> 
    /// 
    public class UserLoginService
    {
        DBHelper DB = new DBHelper();
        public UserLogin userLogin(string roomNumber, string iDNumber)
        { 
            UserLogin userLogin = null; 

            string sql = "select S.IDCard, RoomNumber,UserName from StatementTable S join UserTable U on S.IDCard= U.IDCard where U.IDCard = @IDCard and RoomNumber = @RoomNumber";
            SqlParameter[] sp =
            {
                new SqlParameter("@IDCard",iDNumber),//用户身份证
                new SqlParameter("@RoomNumber",roomNumber)//房间号
            };
            SqlDataReader sdr = DB.ExecuteReader(sql, sp);
            if (sdr.Read())
            {
                userLogin = new UserLogin
                {
                    RoomNumber = roomNumber,
                    IDNumber = iDNumber,
                    UserName = sdr["UserName"].ToString().Trim()
                };
            };

            sdr.Close();

            return userLogin;
        }
    }
}
