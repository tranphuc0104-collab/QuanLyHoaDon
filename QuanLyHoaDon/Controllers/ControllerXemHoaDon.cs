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
    internal class ControllerXemHoaDon
    {
        SqlConnection conn = Connection.GetConnection();
        public DataTable getHoaDon()
        {
            string query = @"
            SELECT HoaDon.MaHD,
                   HoaDon.NgayLap,
                   KhachHang.TenKH,
                   HoaDon.TongTien
            FROM HoaDon
            INNER JOIN KhachHang
            ON HoaDon.MaKH = KhachHang.MaKH";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getChiTiet(string maHD)
        {
            string query = @"
            SELECT ChiTietHoaDon.MaSP,
                   SanPham.TenSP,
                   ChiTietHoaDon.SoLuong,
                   ChiTietHoaDon.DonGia,
                   ChiTietHoaDon.ThanhTien
            FROM ChiTietHoaDon
            INNER JOIN SanPham
            ON ChiTietHoaDon.MaSP = SanPham.MaSP
            WHERE ChiTietHoaDon.MaHD = @MaHD";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaHD", maHD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable searchHoaDon(string keyword)
        {
            string query = @"
            SELECT HoaDon.MaHD,
                   HoaDon.NgayLap,
                   KhachHang.TenKH,
                   HoaDon.TongTien
            FROM HoaDon
            INNER JOIN KhachHang
            ON HoaDon.MaKH = KhachHang.MaKH
            WHERE HoaDon.MaHD LIKE @keyword
               OR KhachHang.TenKH LIKE @keyword";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue(
                "@keyword",
                "%" + keyword + "%"
            );
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool deleteHoaDon(string maHD)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string queryCT = @"
            DELETE FROM ChiTietHoaDon
            WHERE MaHD = @MaHD";
            SqlCommand cmdCT = new SqlCommand(queryCT, conn);
            cmdCT.Parameters.AddWithValue("@MaHD", maHD);
            cmdCT.ExecuteNonQuery();

            string queryHD = @"
            DELETE FROM HoaDon
            WHERE MaHD = @MaHD";
            SqlCommand cmdHD = new SqlCommand(queryHD, conn);
            cmdHD.Parameters.AddWithValue("@MaHD", maHD);
            int result = cmdHD.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}