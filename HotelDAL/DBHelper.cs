using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HotelDAL
{
    /// <summary>
    /// 数据库调用对象
    /// </summary>
    public class DBHelper
    {
        public const string connString = "server=.; database=Hotel; uid=sa; pwd=sa;";
        public SqlConnection conn = null;

        /// <summary>
        /// 构造函数并初始化conn
        /// </summary>
        public SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }
                else if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        public void CloseConnection()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)
                {
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// 插入参数列表
        /// </summary>
        private SqlCommand GetSqlCommand(string sql, SqlParameter[] sp)
        {
            SqlCommand cmd = new SqlCommand(sql, Conn);
            if (sp != null)
            {
                foreach (var param in sp)
                {
                    cmd.Parameters.Add(param);
                }
            }
            return cmd;
        }
        /// <summary>
        /// 增删改操作，返回受影响的行数
        /// </summary>
        public int ExecuteNonQuery(string sql, params SqlParameter[] sp)
        {
            try
            {
                SqlCommand cmd = GetSqlCommand(sql, sp);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        /// <summary>
        /// 单行单列
        /// </summary>
        public object ExecuteScalar(string sql, SqlParameter[] sp)
        {
            try
            {
                SqlCommand cmd = GetSqlCommand(sql, sp);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        /// <summary>
        /// 多行查询
        /// </summary>
        public SqlDataReader ExecuteReader(string sql, params SqlParameter[] sp)
        {
            try
            {
                SqlCommand cmd = GetSqlCommand(sql, sp);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 返回操作表
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="sp">参数列表</param>
        /// <param name="tableName">操作表表名</param>
        public DataTable GetTable(string sql, string tableName = "tableName", params SqlParameter[] sp)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = GetSqlCommand(sql, sp);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, tableName);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
