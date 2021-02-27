using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 顾客
    /// </summary>
    public class UserTable
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public char Gender { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 身份证 (识别属性)
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public long TelephoneNumber { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// 会员等级
        /// </summary>
        public MembershipTable Member { get; set; }
    }
}
