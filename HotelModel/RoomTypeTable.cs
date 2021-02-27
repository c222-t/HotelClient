using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    /// <summary>
    /// 房间类型
    /// </summary>
    public class RoomTypeTable
    {
        /// <summary>
        /// 房间类型编号
        /// </summary>
        public int No { get; set; }
        /// <summary>
        /// 房间类型名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 房间价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public int Days { get; set; }
    }
}
