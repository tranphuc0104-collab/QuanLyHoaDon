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
using System.Windows.Forms.DataVisualization.Charting;
namespace QuanLyHoaDon.Views
{
    public partial class frmDashboard : Form
    {
        ControllerThongKe ctrl = new ControllerThongKe();
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }
        public void loadDashboard()
        {
            lblTongKH.Text = ctrl.tongKhachHang().ToString();
            lblTongSP.Text = ctrl.tongSanPham().ToString();
            lblTongHD.Text = ctrl.tongHoaDon().ToString();
            lblTongDT.Text = ctrl.tongDoanhThu().ToString("N0") + " VNĐ";
        }
        public void loadChartDoanhThu()
        {
            chartDoanhThu.Series.Clear();
            Series s = new Series("DoanhThu");
            s.ChartType = SeriesChartType.Column;
            chartDoanhThu.Series.Add(s);
            DataTable dt = ctrl.doanhThuTheoNgay();
            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM"),
                    row["DoanhThu"]
                );
            }
            s.IsValueShownAsLabel = true;
        }
        public void loadChartSanPham()
        {
            chartSanPham.Series.Clear();
            Series s = new Series("SanPham");
            s.ChartType = SeriesChartType.Pie;
            chartSanPham.Series.Add(s);
            DataTable dt = ctrl.sanPhamBanChay();
            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(row["TenSP"], row["SoLuongBan"]);
            }
            s.IsValueShownAsLabel = true;
            chartSanPham.Legends[0].Docking = Docking.Right;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            loadDashboard();
            loadChartDoanhThu();
            loadChartSanPham();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
