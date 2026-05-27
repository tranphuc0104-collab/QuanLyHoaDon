using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.Database
{
    internal class Connection
    {
        public static SqlConnection GetConnection()
        {
            string strConn = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyHoaDon;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);

            return conn;
        }
    }
}
