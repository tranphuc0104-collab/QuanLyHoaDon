using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoaDon.Controllers;
using QuanLyHoaDon.Models;
using System.Data;

namespace QuanLyHoaDon.Views
{
    public partial class frmHoaDon : Form
    {
        ControllerHoaDon ctrl = new ControllerHoaDon();
        DataTable dtChiTiet = new DataTable();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void createTable()
        {
            dtChiTiet.Columns.Add("MaSP");
            dtChiTiet.Columns.Add("TenSP");
            dtChiTiet.Columns.Add("GiaBan");
            dtChiTiet.Columns.Add("SoLuong");
            dtChiTiet.Columns.Add("ThanhTien");
            dgvChiTietHD.DataSource = dtChiTiet;
        }
        public void loadKhachHang()
        {
            cboKhachHang.DataSource = ctrl.getKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        public void loadSanPham()
        {
            cboSanPham.DataSource = ctrl.getSanPham();
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            createTable();
            loadKhachHang();
            loadSanPham();
            txtMaHD.Text = ctrl.taoMaHD();
        }
        public void tinhThanhTien()
        {
            if (txtGiaBan.Text != "")
            {
                decimal gia = decimal.Parse(txtGiaBan.Text);
                int sl = (int)numSoLuong.Value;
                decimal thanhTien = gia * sl;
                txtThanhTien.Text = thanhTien.ToString();
            }
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedIndex >= 0)
            {
                DataRowView row = (DataRowView)cboSanPham.SelectedItem;
                txtGiaBan.Text = row["GiaBan"].ToString();
                tinhThanhTien();
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            tinhThanhTien();
        }
        public void tinhTongTien()
        {
            decimal tong = 0;
            foreach (DataRow row in dtChiTiet.Rows)
            {
                tong += decimal.Parse(row["ThanhTien"].ToString());
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string maSP = cboSanPham.SelectedValue.ToString();
            string tenSP = cboSanPham.Text;
            decimal giaBan = decimal.Parse(txtGiaBan.Text);
            int soLuong = (int)numSoLuong.Value;
            decimal thanhTien = decimal.Parse(txtThanhTien.Text);
            dtChiTiet.Rows.Add(maSP,tenSP,giaBan,soLuong,thanhTien);
            tinhTongTien();
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = txtMaHD.Text;
            hd.NgayLap = dtNgayLap.Value;
            hd.MaKH = cboKhachHang.SelectedValue.ToString();
            hd.TongTien = decimal.Parse(txtTongTien.Text);
            bool resultHD = ctrl.insertHoaDon(hd);
            if (resultHD)
            {
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    ct.MaHD = txtMaHD.Text;
                    ct.MaSP = row["MaSP"].ToString();
                    ct.DonGia = decimal.Parse(row["GiaBan"].ToString());
                    ct.SoLuong = int.Parse(row["SoLuong"].ToString());
                    ct.ThanhTien = decimal.Parse(row["ThanhTien"].ToString());
                    ctrl.insertChiTiet(ct);
                }
                MessageBox.Show("Lưu hóa đơn thành công!");
                dtChiTiet.Rows.Clear();
                txtTongTien.Clear();
                txtMaHD.Text = ctrl.taoMaHD();
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
    }
}
