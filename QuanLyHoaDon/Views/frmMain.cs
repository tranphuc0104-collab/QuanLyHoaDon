using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHoaDon.Views;
namespace QuanLyHoaDon.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
            lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            panelBody.BackColor = Color.FromArgb(180, 255, 255, 255);
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
            lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
            lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXemHoaDon());
            lblTitle.Text = "XEM HÓA ĐƠN";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
            lblTitle.Text = "THỐNG KÊ";
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
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
                this.Close();
            }
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatHang());
            lblTitle.Text = "THỐNG KÊ";
        }
    }
}
