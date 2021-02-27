using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{/// <summary>
 /// 商品
 /// </summary>
    public class CommodityTable
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string CommodityName { get; set; }
        /// <summary>
        /// 商品单位
        /// </summary>
        public string CommodityUnit { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 商品类型
        /// </summary>
        public CommodityTypeTable Type { get; set; }
        /// <summary>
        /// 商品进价
        /// </summary>
        public double PurchasePice { get; set; }
        /// <summary>
        /// 商品零售
        /// </summary>
        public double Retail { get; set; }
    }
}

