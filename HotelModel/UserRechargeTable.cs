using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 顾客充值记录
    /// </summary>
    public class UserRechargeTable
    {
        /// <summary>
        /// 充值记录编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 充值金额
        /// </summary>
        public double RechargeBalance { get; set; }
        /// <summary>
        /// 用户身份证 (识别属性)
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 充值时间
        /// </summary>
        public DateTime RechargeTime { get; set; }
        /// <summary>
        /// 赠送礼品
        /// </summary>
        public CommodityTable GiftGiving { get; set; }

        public UserRechargeTable()
        {
            this.RechargeTime = DateTime.Now;                            // 获取当前充值时间
        }
    }
}
