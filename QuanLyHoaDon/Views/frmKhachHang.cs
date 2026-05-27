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
    public partial class frmKhachHang : Form
    {
        ControllerKhachHang ctrl = new ControllerKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvKhachHang.DataSource = ctrl.getAllKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text.Trim();
            kh.TenKH = txtTenKH.Text.Trim();
            kh.SoDienThoai = txtSDT.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            bool result = ctrl.insertKhachHang(kh);
            if (result)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text.Trim();
            kh.TenKH = txtTenKH.Text.Trim();
            kh.SoDienThoai = txtSDT.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.Email = txtEmail.Text.Trim();
            bool result = ctrl.updateKhachHang(kh);
            if (result)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
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
            "Bạn có muốn xóa khách hàng này không?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string maKH = txtMaKH.Text.Trim();
                bool result = ctrl.deleteKhachHang(maKH);
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
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtMaKH.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvKhachHang.DataSource = ctrl.searchKhachHang(keyword);
        }
    }
}
