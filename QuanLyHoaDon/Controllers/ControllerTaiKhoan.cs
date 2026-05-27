using QuanLyHoaDon.Database;
using QuanLyHoaDon.Models;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHoaDon.Controllers
{
    internal class ControllerTaiKhoan
    {
        SqlConnection conn =Connection.GetConnection();
        public bool checkUsername(
            string username)
        {
            string query =
                @"SELECT COUNT(*)
                FROM TaiKhoan
                WHERE Username=@u";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u",username);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }

        public bool insertTaiKhoan(TaiKhoan tk)
        {
            string query = @"INSERT INTO TaiKhoan
                            VALUES(@Username,@Password,@Quyen,@MaKH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username",tk.Username);
            cmd.Parameters.AddWithValue("@Password",tk.Password);
            cmd.Parameters.AddWithValue("@Quyen",tk.Quyen);
            cmd.Parameters.AddWithValue("@MaKH",tk.MaKH);
            conn.Open();
            int result =cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}