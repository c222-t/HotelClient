using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data;

namespace HotelDAL
{
    public class HotelServiceDataLayer
    {
        DBHelper DB = new DBHelper();
        public List<CommodityTable> tables()
        {
            List<CommodityTable> ct = new List<CommodityTable>();

            string sql = "select Number, CommodityName, CommodityUnit, Quantity,retail,[Path] from CommodityTable";

            DataTable dt = DB.GetTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                CommodityTable table = new CommodityTable
                {
                    Number = dr["Number"].ToString(),
                    PicturePath = dr["Path"].ToString(),
                    CommodityName = dr["CommodityName"].ToString(),
                    CommodityUnit = dr["CommodityUnit"].ToString(),
                    Retail = (double)dr["retail"]
                };
                ct.Add(table);
            }
            return ct;
        }
    }
}
