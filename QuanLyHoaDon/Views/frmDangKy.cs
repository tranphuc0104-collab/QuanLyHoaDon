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

namespace QuanLyHoaDon.Views
{
    public partial class frmDangKy : Form
    {
        ControllerKhachHang ctrlKH = new ControllerKhachHang();
        ControllerTaiKhoan ctrlTK = new ControllerTaiKhoan();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "" ||
               txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" ||
               txtNhapLaiMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtPassword.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!");
                txtNhapLaiMK.Focus();
                return;
            }

            if (ctrlTK.checkUsername(txtUsername.Text))
            {
                MessageBox.Show("Username đã tồn tại!");
                txtUsername.Focus();
                return;
            }

            string maKH =ctrlKH.taoMaKH();
            KhachHang kh = new KhachHang();
            kh.MaKH = maKH;
            kh.TenKH = txtTenKH.Text;
            kh.SoDienThoai = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.Email = txtEmail.Text;
            bool resultKH = ctrlKH.insertKhachHang(kh);

            // Nếu thêm khách hàng thành công
            if (resultKH)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.Username = txtUsername.Text;
                tk.Password = txtPassword.Text;
                tk.Quyen = "User";
                tk.MaKH = maKH;
                bool resultTK = ctrlTK.insertTaiKhoan(tk);

                if (resultTK)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = ctrlKH.taoMaKH();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtNhapLaiMK.Clear();
            txtTenKH.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMaKH.Text =ctrlKH.taoMaKH();
        }
    }
}
