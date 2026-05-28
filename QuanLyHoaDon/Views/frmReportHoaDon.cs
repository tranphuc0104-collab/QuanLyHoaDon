using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyHoaDon.Controllers;
using System.Data;

namespace QuanLyHoaDon.Views
{
    public partial class frmReportHoaDon : Form
    {
        public frmReportHoaDon()
        {
            InitializeComponent();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
            ControllerHoaDon ctrlHD =new ControllerHoaDon();
            DataTable dt =ctrlHD.getReportHoaDon();
            ReportDataSource rds =new ReportDataSource("dsHoaDon",dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"../../rptHoaDon.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
