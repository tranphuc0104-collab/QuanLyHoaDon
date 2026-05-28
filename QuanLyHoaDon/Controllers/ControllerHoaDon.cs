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
    internal class ControllerHoaDon
    {
        SqlConnection conn = Connection.GetConnection();
        public DataTable getKhachHang()
        {
            string query = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getSanPham()
        {
            string query = "SELECT * FROM SanPham";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insertHoaDon(HoaDon hd)
        {
            string query = @"INSERT INTO HoaDon
                            VALUES(@MaHD,@NgayLap,@MaKH,@TongTien)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
            cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
            cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool insertChiTiet(ChiTietHoaDon ct)
        {
            string query = @"INSERT INTO ChiTietHoaDon
                            VALUES(@MaHD,@MaSP,@SoLuong,@DonGia,@ThanhTien)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaHD", ct.MaHD);
            cmd.Parameters.AddWithValue("@MaSP", ct.MaSP);
            cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien", ct.ThanhTien);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        public string taoMaHD()
        {
            string ma = "HD01";
            string query = @"SELECT TOP 1 MaHD
                    FROM HoaDon
                    ORDER BY MaHD DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string oldMa = dt.Rows[0]["MaHD"].ToString();
                int number = int.Parse(oldMa.Substring(2)) + 1;
                ma = "HD" + number.ToString("00");
            }
            return ma;
        }
        public DataTable getHoaDonByMaKH(string maKH)
        {
            string query = @"SELECT MaHD,NgayLap,TongTien FROM HoaDon WHERE MaKH=@MaKH";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaKH", maKH);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getReportHoaDon()
        {
            string query = @"
                SELECT HoaDon.MaHD,
                       HoaDon.NgayLap,
                       KhachHang.TenKH,
                       SanPham.TenSP,
                       ChiTietHoaDon.SoLuong,
                       ChiTietHoaDon.DonGia,
                       ChiTietHoaDon.ThanhTien,
                       HoaDon.TongTien
                FROM HoaDon
                INNER JOIN KhachHang
                ON HoaDon.MaKH = KhachHang.MaKH
                INNER JOIN ChiTietHoaDon
                ON HoaDon.MaHD = ChiTietHoaDon.MaHD
                INNER JOIN SanPham
                ON ChiTietHoaDon.MaSP = SanPham.MaSP";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
