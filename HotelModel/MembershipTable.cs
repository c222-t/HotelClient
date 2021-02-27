using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 顾客会员等级
    /// </summary>
    public class MembershipTable
    {
        /// <summary>
        /// 会员编号
        /// </summary>
        public int MemberNumber { get; set; }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string MembershipLevel { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public double Discount { get; set; }
    }
}
