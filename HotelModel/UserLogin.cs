using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public class UserLogin
    {
        /// <summary>
        /// 房间号
        /// </summary>
        string roomNumber;
        /// <summary>
        /// 身份证号
        /// </summary>
        string iDNumber;
        /// <summary>
        /// 用户姓名
        /// </summary>
        string userName;

        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string IDNumber { get => iDNumber; set => iDNumber = value; }
        public string UserName { get => userName; set => userName = value; }
    }

    public class userLoginManager
    {
    }
}
