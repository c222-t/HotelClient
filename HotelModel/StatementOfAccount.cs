using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    public class StatementOfAccount
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }

        /// <summary>
        /// 总消费
        /// </summary>
        public string TotalConsumption { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public string money { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        public string SpendingTime { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Describe { get; set; }
    }
}
