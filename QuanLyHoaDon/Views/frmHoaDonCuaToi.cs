using QuanLyHoaDon.Controllers;
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
    public partial class frmHoaDonCuaToi : Form
    {
        ControllerHoaDon ctrlHD = new ControllerHoaDon();
        ControllerChiTietHoaDon ctrlCT = new ControllerChiTietHoaDon();
        public frmHoaDonCuaToi()
        {
            InitializeComponent();
        }

        private void frmHoaDonCuaToi_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ctrlHD.getHoaDonByMaKH(Session.MaKH);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD =dgvHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                dgvChiTiet.DataSource = ctrlCT.getChiTietByMaHD(maHD);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
