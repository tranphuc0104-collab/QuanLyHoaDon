using QuanLyHoaDon.Controllers;
using QuanLyHoaDon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyHoaDon.Views
{
    public partial class frmDatHang : Form
    {
        ControllerSanPham ctrlSP = new ControllerSanPham();
        ControllerHoaDon ctrlHD = new ControllerHoaDon();
        ControllerChiTietHoaDon ctrlCT = new ControllerChiTietHoaDon();
        public frmDatHang()
        {
            InitializeComponent();
        }
        public void tinhTongTien()
        {
            int tong = 0;
            foreach (DataGridViewRow row
                in dgvGioHang.Rows)
            {
                tong += Convert.ToInt32(row.Cells["colThanhTien"].Value);
            }
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }
        public void themSanPhamVaoGio(string maSP)
        {
            DataTable dt = ctrlSP.getSanPhamByMa(maSP);
            if (dt.Rows.Count > 0)
            {
                string tenSP = dt.Rows[0]["TenSP"].ToString();
                int gia = Convert.ToInt32(dt.Rows[0]["GiaBan"]);
                bool daTonTai = false;
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    if (row.Cells["colMaSP"].Value.ToString() == maSP)
                    {
                        int sl = Convert.ToInt32(row.Cells["colSoLuong"].Value);
                        sl++;
                        row.Cells["colSoLuong"].Value = sl;
                        row.Cells["colThanhTien"].Value = sl * gia;
                        daTonTai = true;
                        break;
                    }
                }
                if (!daTonTai)
                {
                    dgvGioHang.Rows.Add(maSP,tenSP,gia,1,gia);
                }
                tinhTongTien();
            }
        }
        private void btnThemBMT_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP01");}
        private void btnThemBMTr_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP02");}
        private void btnThemCFD_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP03");}
        private void btnThemCFS_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP04");}
        private void btnThemTSTT_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP05");}
        private void btnThemTDCS_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP06");}
        private void btnThemNEC_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP07");}
        private void btnThemSTX_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP08");}
        private void btnThemMXB_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP09");}
        private void btnThemCCHS_Click(object sender, EventArgs e)
        {themSanPhamVaoGio("SP10");}
        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvGioHang.Columns["colXoa"].Index)
            {
                dgvGioHang.Rows.RemoveAt(e.RowIndex);
                tinhTongTien();
            }
        }

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int gia =Convert.ToInt32(dgvGioHang.Rows[e.RowIndex].Cells["colGia"].Value);
            int soLuong = Convert.ToInt32(dgvGioHang.Rows[e.RowIndex] .Cells["colSoLuong"].Value);
            int thanhTien = gia * soLuong;
            dgvGioHang.Rows[e.RowIndex].Cells["colThanhTien"].Value = thanhTien;
            tinhTongTien();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Session.DaDangNhap == false)
            {
                MessageBox.Show("Vui lòng đăng nhập!");
                frmLogin f =new frmLogin();
                f.ShowDialog();
                return;
            }
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            string maHD = ctrlHD.taoMaHD();
            decimal tongTien = 0;
            foreach (DataGridViewRow row
                in dgvGioHang.Rows)
            {
                tongTien += Convert.ToDecimal( row.Cells["colThanhTien"].Value);
            }
            HoaDon hd = new HoaDon();
            hd.MaHD = maHD;
            hd.NgayLap = DateTime.Now;
            hd.MaKH = Session.MaKH;
            hd.TongTien = tongTien;
            bool result =ctrlHD.insertHoaDon(hd);
            if (result)
            {
                foreach (DataGridViewRow row
                    in dgvGioHang.Rows)
                {
                    ChiTietHoaDon ct =new ChiTietHoaDon();
                    ct.MaHD = maHD;
                    ct.MaSP =row.Cells["colMaSP"].Value.ToString();
                    ct.SoLuong = Convert.ToInt32( row.Cells["colSoLuong"].Value);

                    ct.DonGia = Convert.ToDecimal( row.Cells["colGia"].Value);
                    ct.ThanhTien =Convert.ToDecimal( row.Cells["colThanhTien"].Value);
                    ctrlCT.insertChiTietHoaDon(ct);
                }
                MessageBox.Show("Đặt hàng thành công!");
                dgvGioHang.Rows.Clear();
                tinhTongTien();
            }
        }
        public void capNhatTrangThaiLogin()
        {
            if (Session.DaDangNhap)
            {
                btnLogin_Logout.Text = "ĐĂNG XUẤT";
                lblXinChao.Text = "Xin chào " + Session.Username;
            }
            else
            {
                btnLogin_Logout.Text = "ĐĂNG NHẬP";
                lblXinChao.Text = "Xin chào khách";
            }
        }
        private void frmDatHang_Load(object sender, EventArgs e)
        {
            capNhatTrangThaiLogin();
        }

        private void btnLogin_Logout_Click(object sender, EventArgs e)
        {
            if (Session.DaDangNhap == false)
            {
                frmLogin f = new frmLogin();
                f.ShowDialog();
                capNhatTrangThaiLogin();
            }
            else
            {
                DialogResult result =
                    MessageBox.Show(
                        "Bạn có muốn đăng xuất không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    Session.Username = "";
                    Session.MaKH = "";
                    Session.Quyen = "";
                    Session.DaDangNhap = false;
                    capNhatTrangThaiLogin();
                    MessageBox.Show("Đã đăng xuất!");
                }
            }
        }

        private void btnHoaDonCuaToi_Click(object sender, EventArgs e)
        {
            if (Session.DaDangNhap == false)
            {
                MessageBox.Show("Vui lòng đăng nhập!");
                frmLogin f =new frmLogin();
                f.ShowDialog();
                return;
            }
            frmHoaDonCuaToi fHD =new frmHoaDonCuaToi();
            fHD.ShowDialog();
        }

        private void btnML_Click(object sender, EventArgs e)
        { themSanPhamVaoGio("SP11"); }
        private void btnSBH_Click(object sender, EventArgs e)
        { themSanPhamVaoGio("SP12"); }
        private void btnTC_Click(object sender, EventArgs e)
        { themSanPhamVaoGio("SP13"); }
        private void btnTRMS_Click(object sender, EventArgs e)
        { themSanPhamVaoGio("SP14"); }
        private void btnSK_Click(object sender, EventArgs e)
        { themSanPhamVaoGio("SP15"); }
    }
}