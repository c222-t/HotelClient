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

        public List<StatementOfAccount> statement(string idCard)
        {
            List<StatementOfAccount> ofAccounts = new List<StatementOfAccount>();

            string sql = "select UserName ,s.RoomNumber,PaymentMethod ,Describe,money,SpendingTime,s.TotalConsumption from ConsumptionRecord c join StatementTable s on s.IDCard = c.IDCard join UserTable u on u.IDCard = c.IDCard where c.IDCard = @idCard ";

            SqlParameter[] sp =
            {
                new SqlParameter("@idCard",idCard)
            };
            DataTable dt = DB.GetTable(sql, "ConsumptionRecord", sp);

            foreach (DataRow dr in dt.Rows)
            {
                StatementOfAccount lx = new StatementOfAccount
                {
                    Name = dr["UserName"].ToString(),
                    RoomNumber = dr["RoomNumber"].ToString(),
                    PaymentMethod = dr["PaymentMethod"].ToString(),
                    TotalConsumption = dr["TotalConsumption"].ToString(),
                    money = dr["money"].ToString(),
                    SpendingTime = dr["SpendingTime"].ToString(),
                    Describe = dr["Describe"].ToString()
                };
                ofAccounts.Add(lx);
            }
            return ofAccounts;
        }
    }
}
