using QuanLyHoaDon.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoaDon.Controllers
{
    internal class ControllerThongKe
    {
        SqlConnection conn = Connection.GetConnection();
        public int tongKhachHang()
        {
            string query = "SELECT COUNT(*) FROM KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
        public int tongSanPham()
        {
            string query = "SELECT COUNT(*) FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
        public int tongHoaDon()
        {
            string query = "SELECT COUNT(*) FROM HoaDon";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
        public decimal tongDoanhThu()
        {
            string query = "SELECT SUM(TongTien) FROM HoaDon";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            if (result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            return 0;
        }

        public DataTable doanhThuTheoNgay()
        {
            string query = @"
            SELECT NgayLap,SUM(TongTien) AS DoanhThu
            FROM HoaDon
            GROUP BY NgayLap";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable sanPhamBanChay()
        {
            string query = @"
            SELECT SanPham.TenSP,SUM(ChiTietHoaDon.SoLuong) AS SoLuongBan
            FROM ChiTietHoaDon
            INNER JOIN SanPham
            ON ChiTietHoaDon.MaSP = SanPham.MaSP
            GROUP BY SanPham.TenSP";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
