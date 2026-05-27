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
namespace QuanLyHoaDon.Views
{
    public partial class frmSanPham : Form
    {
        ControllerSanPham ctrl = new ControllerSanPham();
        public frmSanPham()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvSanPham.DataSource = ctrl.getAllSanPham();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();
            sp.GiaBan = decimal.Parse(txtDonGia.Text);
            sp.DonViTinh = txtDonViTinh.Text.Trim();
            bool result = ctrl.insertSanPham(sp);
            if (result)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();
            sp.GiaBan = decimal.Parse(txtDonGia.Text);
            sp.DonViTinh = txtDonViTinh.Text.Trim();
            bool result = ctrl.updateSanPham(sp);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
            "Bạn có muốn xóa sản phẩm này không?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string maSP = txtMaSP.Text.Trim();
                bool result = ctrl.deleteSanPham(maSP);
                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtDonViTinh.Clear();
            txtMaSP.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvSanPham.DataSource = ctrl.searchSanPham(keyword);
        }
    }
}
