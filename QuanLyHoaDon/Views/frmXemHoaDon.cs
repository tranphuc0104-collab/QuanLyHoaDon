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

namespace QuanLyHoaDon.Views
{
    public partial class frmXemHoaDon : Form
    {
        ControllerXemHoaDon ctrl = new ControllerXemHoaDon();
        public frmXemHoaDon()
        {
            InitializeComponent();
        }
        public void loadHoaDon()
        {
            dgvHoaDon.DataSource = ctrl.getHoaDon();
        }

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD = dgvHoaDon.Rows[e.RowIndex]
                    .Cells["MaHD"].Value.ToString();
                dgvChiTiet.DataSource = ctrl.getChiTiet(maHD);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvHoaDon.DataSource = ctrl.searchHoaDon(keyword);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                string maHD = dgvHoaDon.CurrentRow.Cells["MaHD"].Value.ToString();
                DialogResult rs = MessageBox.Show(
                    "Bạn có muốn xóa hóa đơn này không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (rs == DialogResult.Yes)
                {
                    bool check = ctrl.deleteHoaDon(maHD);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công!");
                        loadHoaDon();
                        dgvChiTiet.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }
    }
}
