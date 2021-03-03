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
        /// 图片路径
        /// </summary>
        public string PicturePath{ get; set; }
    /// <summary>
    /// 商品名称
    /// </summary>
       public string CommodityName { get; set; }
        /// <summary>
        /// 商品单位
        /// </summary>
        public string CommodityUnit { get; set; }
       
        /// <summary>
        /// 商品零售
        /// </summary>
        public double Retail { get; set; }
    }
}

