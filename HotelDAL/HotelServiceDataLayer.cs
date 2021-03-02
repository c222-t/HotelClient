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

            string sql = "select CommodityName,CommodityUnit,retail from CommodityTable where 1=1";

            DataTable dt = DB.GetTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                CommodityTable table = new CommodityTable
                {
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
