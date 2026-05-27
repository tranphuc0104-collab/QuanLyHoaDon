using QuanLyHoaDon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoaDon.Controllers;
namespace QuanLyHoaDon.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            ControllerLogin login = new ControllerLogin();
            bool check = login.CheckLogin(username, password);
            if (check)
            {
                string role = login.GetRole(username);
                Session.Username = username;
                Session.Quyen = role;
                Session.DaDangNhap = true;
                if (role == "User")
                {
                    Session.MaKH = login.getMaKH(username);
                    MessageBox.Show("Đăng nhập thành công!\nQuyền: User");
                    this.Close();
                }
                else
                {
                    Session.MaKH = login.getMaKH(username);
                    MessageBox.Show("Đăng nhập thành công!\nQuyền: Admin");
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát không?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy f = new frmDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}