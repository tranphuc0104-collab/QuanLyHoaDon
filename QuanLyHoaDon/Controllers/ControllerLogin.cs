using QuanLyHoaDon.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.Controllers
{
    internal class ControllerLogin
    {
        public bool CheckLogin(string username, string password)
        {
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE Username=@user AND PasswordTK=@pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        public string GetRole(string username)
        {
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT Quyen FROM TaiKhoan WHERE Username=@user";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", username);
            conn.Open();
            string role = cmd.ExecuteScalar().ToString();
            conn.Close();
            return role;
        }
        public string getMaKH(string username)
        {
            SqlConnection conn = Connection.GetConnection();
            string maKH = "";
            string query = "SELECT MaKH FROM TaiKhoan WHERE Username=@u";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u",username);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                maKH = result.ToString();
            }
            conn.Close();
            return maKH;
        }
    }
}
