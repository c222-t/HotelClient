using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class ReportDataLayer
    {
        DBHelper DB = new DBHelper();

        public StatementOfAccount statement(string idCard)
        {
            StatementOfAccount statement = null;

            string sql = "select s.RoomNumber ,PaymentMethod ,c.IDCard ,Describe,money,SpendingTime,s.TotalConsumption from ConsumptionRecord c join StatementTable s on s.IDCard = c.IDCard where c.IDCard=@IDCard";

            SqlParameter[] sp =
            {
                new SqlParameter("@IDCard",idCard)
            };

            SqlDataReader dr = DB.ExecuteReader(sql, sp);

            if (dr.Read())
            {
                statement = new StatementOfAccount
                {
                    RoomNumber = dr["RoomNumber"].ToString(),
                    IDCard = dr["IDCard"].ToString(),
                    TotalConsumption = dr["TotalConsumption"].ToString(),
                    money = dr["money"].ToString(),
                    SpendingTime = dr["SpendingTime"].ToString(),
                    Describe = dr["Describe"].ToString()
                };
            }
            return statement;
        }
    }
}
