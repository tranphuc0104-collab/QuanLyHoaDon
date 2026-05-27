using QuanLyHoaDon.Database;
using QuanLyHoaDon.Models;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHoaDon.Controllers
{
    internal class ControllerSanPham
    {
        SqlConnection conn = Connection.GetConnection();
        public DataTable getAllSanPham()
        {
            string query = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insertSanPham(SanPham sp)
        {
            string query = @"INSERT INTO SanPham
                            VALUES(@MaSP,@TenSP,@GiaBan,@DonViTinh)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool updateSanPham(SanPham sp)
        {
            string query = @"UPDATE SanPham
                            SET TenSP=@TenSP,
                                GiaBan=@GiaBan,
                                DonViTinh=@DonViTinh
                            WHERE MaSP=@MaSP";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
            cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
            cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
            cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool deleteSanPham(string maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP=@MaSP";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSP", maSP);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public DataTable searchSanPham(string keyword)
        {
            string query = @"SELECT * FROM SanPham
                            WHERE MaSP LIKE @keyword
                               OR TenSP LIKE @keyword
                               OR CAST(GiaBan AS NVARCHAR) LIKE @keyword
                               OR DonViTinh LIKE @keyword";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getSanPhamByMa(string maSP)
        {
            string query ="SELECT * FROM SanPham WHERE MaSP=@MaSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaSP",maSP);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}