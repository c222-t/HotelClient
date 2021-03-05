using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;
using System.Data;

namespace HotelDAL
{
    public class ReportDataLayer
    {
        DBHelper DB = new DBHelper();

        public StatementOfAccount statement(string idCard)
        {
            StatementOfAccount ofAccounts = null;

            string sql = "select  u.Balance,s.TotalConsumption from StatementTable s join UserTable u on u.IDCard = s.IDCard where s.IDCard = @idCard ";

            SqlParameter[] sp =
            {
                new SqlParameter("@idCard",idCard)
            };
            DataTable dt = DB.GetTable(sql, "ConsumptionRecord", sp);

            foreach (DataRow dr in dt.Rows)
            {
                ofAccounts = new StatementOfAccount
                {
                    TotalConsumption = dr["TotalConsumption"].ToString(),//总消费
                    money = dr["Balance"].ToString()//余额
                };

            }
            return ofAccounts;
        }
    }
}
