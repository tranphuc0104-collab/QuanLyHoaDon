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
    internal class ControllerChiTietHoaDon
    {
        SqlConnection conn = Connection.GetConnection();
        public bool insertChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = @"INSERT INTO ChiTietHoaDon 
                             VALUES(@MaHD,@MaSP,@SoLuong,@DonGia,@ThanhTien)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaHD",cthd.MaHD);
            cmd.Parameters.AddWithValue("@MaSP",cthd.MaSP);
            cmd.Parameters.AddWithValue("@SoLuong",cthd.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia",cthd.DonGia);
            cmd.Parameters.AddWithValue("@ThanhTien",cthd.ThanhTien);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result =cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        public DataTable getChiTietByMaHD(
    string maHD)
        {
            string query = @"
            SELECT SanPham.MaSP,
                   SanPham.TenSP,
                   ChiTietHoaDon.SoLuong,
                   ChiTietHoaDon.DonGia,
                   ChiTietHoaDon.ThanhTien
            FROM ChiTietHoaDon
            INNER JOIN SanPham
            ON ChiTietHoaDon.MaSP = SanPham.MaSP
            WHERE MaHD=@MaHD";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaHD",maHD);
            DataTable dt =new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
