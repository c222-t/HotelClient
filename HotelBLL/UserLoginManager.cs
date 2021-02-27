using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    /// <summary>
    /// 用户登录
    /// </summary>
    public class UserLoginManager
    {
        private UserLoginService userLoginService = new UserLoginService();
        public UserLogin userLogin(string roomNumber, string iDNumber)
        {
            return userLoginService.userLogin(roomNumber, iDNumber);
        }
    }
}
