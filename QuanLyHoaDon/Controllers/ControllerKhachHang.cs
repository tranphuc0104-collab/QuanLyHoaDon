using QuanLyHoaDon.Database;
using QuanLyHoaDon.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.Controllers
{
    internal class ControllerKhachHang
    {
        SqlConnection conn = Connection.GetConnection();

        public DataTable getAllKhachHang()
        {
            string query = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insertKhachHang(KhachHang kh)
        {
            string query = @"INSERT INTO KhachHang
                            VALUES (@MaKH,@TenKH,@SDT,@DiaChi,@Email)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@SDT", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@Email", kh.Email);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool updateKhachHang(KhachHang kh)
        {
            string query = @"UPDATE KhachHang
                            SET TenKH=@TenKH,
                                SoDienThoai=@SDT,
                                DiaChi=@DiaChi,
                                Email=@Email
                            WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@SDT", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("@Email", kh.Email);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool deleteKhachHang(string maKH)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            string TK = "DELETE FROM TaiKhoan WHERE MaKH = @MaKH";
            SqlCommand cmdTK = new SqlCommand(TK, conn);
            cmdTK.Parameters.AddWithValue("@MaKH", maKH);
            cmdTK.ExecuteNonQuery();

            string kh = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
            SqlCommand cmdkh = new SqlCommand(kh, conn);
            cmdkh.Parameters.AddWithValue("@MaKH", maKH);
            int result = cmdkh.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public DataTable searchKhachHang(string keyword)
        {
            string query = @"SELECT * FROM KhachHang
                            WHERE MaKH LIKE @keyword
                               OR TenKH LIKE @keyword
                               OR SoDienThoai LIKE @keyword
                               OR DiaChi LIKE @keyword
                               OR Email LIKE @keyword";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string taoMaKH()
        {
            string ma = "KH01";
            string query = @"
            SELECT TOP 1 MaKH
            FROM KhachHang
            ORDER BY MaKH DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string oldMa = dt.Rows[0]["MaKH"].ToString();
                int number = int.Parse(oldMa.Substring(2)) + 1;
                ma = "KH" + number.ToString("00");
            }
            return ma;
        }
    }
}

