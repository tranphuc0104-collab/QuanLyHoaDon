namespace QuanLyHoaDon.Views
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlKH = new System.Windows.Forms.Panel();
            this.lblTongKH = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblIconKH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongSP = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblIconSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.lblHD = new System.Windows.Forms.Label();
            this.lblIconHD = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblIconDT = new System.Windows.Forms.Label();
            this.lblTongDT = new System.Windows.Forms.Label();
            this.pnlChart1 = new System.Windows.Forms.Panel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChart2 = new System.Windows.Forms.Panel();
            this.chartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlKH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.pnlChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblHello);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1127, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTime.Location = new System.Drawing.Point(880, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 28);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.Gray;
            this.lblHello.Location = new System.Drawing.Point(35, 59);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(178, 25);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Xin chào Admin 👋";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(515, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard quản lý hệ thống";
            // 
            // pnlKH
            // 
            this.pnlKH.BackColor = System.Drawing.Color.White;
            this.pnlKH.Controls.Add(this.lblTongKH);
            this.pnlKH.Controls.Add(this.lblKH);
            this.pnlKH.Controls.Add(this.lblIconKH);
            this.pnlKH.Location = new System.Drawing.Point(35, 120);
            this.pnlKH.Name = "pnlKH";
            this.pnlKH.Size = new System.Drawing.Size(220, 130);
            this.pnlKH.TabIndex = 1;
            // 
            // lblTongKH
            // 
            this.lblTongKH.AutoSize = true;
            this.lblTongKH.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKH.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTongKH.Location = new System.Drawing.Point(82, 60);
            this.lblTongKH.Name = "lblTongKH";
            this.lblTongKH.Size = new System.Drawing.Size(54, 62);
            this.lblTongKH.TabIndex = 2;
            this.lblTongKH.Text = "0";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(67, 30);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(135, 25);
            this.lblKH.TabIndex = 1;
            this.lblKH.Text = "KHÁCH HÀNG";
            // 
            // lblIconKH
            // 
            this.lblIconKH.AutoSize = true;
            this.lblIconKH.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconKH.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblIconKH.Location = new System.Drawing.Point(2, 15);
            this.lblIconKH.Name = "lblIconKH";
            this.lblIconKH.Size = new System.Drawing.Size(84, 57);
            this.lblIconKH.TabIndex = 0;
            this.lblIconKH.Text = "👤";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTongSP);
            this.panel1.Controls.Add(this.lblSP);
            this.panel1.Controls.Add(this.lblIconSP);
            this.panel1.Location = new System.Drawing.Point(261, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 130);
            this.panel1.TabIndex = 3;
            // 
            // lblTongSP
            // 
            this.lblTongSP.AutoSize = true;
            this.lblTongSP.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSP.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTongSP.Location = new System.Drawing.Point(95, 60);
            this.lblTongSP.Name = "lblTongSP";
            this.lblTongSP.Size = new System.Drawing.Size(54, 62);
            this.lblTongSP.TabIndex = 2;
            this.lblTongSP.Text = "0";
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP.Location = new System.Drawing.Point(80, 30);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(109, 25);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "SẢN PHẨM";
            // 
            // lblIconSP
            // 
            this.lblIconSP.AutoSize = true;
            this.lblIconSP.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconSP.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblIconSP.Location = new System.Drawing.Point(15, 15);
            this.lblIconSP.Name = "lblIconSP";
            this.lblIconSP.Size = new System.Drawing.Size(84, 57);
            this.lblIconSP.TabIndex = 0;
            this.lblIconSP.Text = "📦";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTongHD);
            this.panel2.Controls.Add(this.lblHD);
            this.panel2.Controls.Add(this.lblIconHD);
            this.panel2.Location = new System.Drawing.Point(487, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 130);
            this.panel2.TabIndex = 3;
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHD.ForeColor = System.Drawing.Color.Crimson;
            this.lblTongHD.Location = new System.Drawing.Point(95, 60);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(54, 62);
            this.lblTongHD.TabIndex = 2;
            this.lblTongHD.Text = "0";
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHD.Location = new System.Drawing.Point(80, 30);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(99, 25);
            this.lblHD.TabIndex = 1;
            this.lblHD.Text = "HÓA ĐƠN";
            // 
            // lblIconHD
            // 
            this.lblIconHD.AutoSize = true;
            this.lblIconHD.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconHD.Location = new System.Drawing.Point(15, 15);
            this.lblIconHD.Name = "lblIconHD";
            this.lblIconHD.Size = new System.Drawing.Size(84, 57);
            this.lblIconHD.TabIndex = 0;
            this.lblIconHD.Text = "🧾";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDT);
            this.panel3.Controls.Add(this.lblIconDT);
            this.panel3.Controls.Add(this.lblTongDT);
            this.panel3.Location = new System.Drawing.Point(713, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 130);
            this.panel3.TabIndex = 3;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDT.Location = new System.Drawing.Point(72, 30);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(123, 25);
            this.lblDT.TabIndex = 1;
            this.lblDT.Text = "DOANH THU";
            // 
            // lblIconDT
            // 
            this.lblIconDT.AutoSize = true;
            this.lblIconDT.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconDT.ForeColor = System.Drawing.Color.Gold;
            this.lblIconDT.Location = new System.Drawing.Point(7, 15);
            this.lblIconDT.Name = "lblIconDT";
            this.lblIconDT.Size = new System.Drawing.Size(84, 57);
            this.lblIconDT.TabIndex = 0;
            this.lblIconDT.Text = "💰";
            // 
            // lblTongDT
            // 
            this.lblTongDT.AutoSize = true;
            this.lblTongDT.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDT.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTongDT.Location = new System.Drawing.Point(6, 60);
            this.lblTongDT.Name = "lblTongDT";
            this.lblTongDT.Size = new System.Drawing.Size(170, 62);
            this.lblTongDT.TabIndex = 2;
            this.lblTongDT.Text = "0 VNĐ";
            // 
            // pnlChart1
            // 
            this.pnlChart1.BackColor = System.Drawing.Color.White;
            this.pnlChart1.Controls.Add(this.chartDoanhThu);
            this.pnlChart1.Location = new System.Drawing.Point(35, 290);
            this.pnlChart1.Name = "pnlChart1";
            this.pnlChart1.Size = new System.Drawing.Size(520, 420);
            this.pnlChart1.TabIndex = 4;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(520, 420);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // pnlChart2
            // 
            this.pnlChart2.BackColor = System.Drawing.Color.White;
            this.pnlChart2.Controls.Add(this.chartSanPham);
            this.pnlChart2.Location = new System.Drawing.Point(585, 290);
            this.pnlChart2.Name = "pnlChart2";
            this.pnlChart2.Size = new System.Drawing.Size(520, 420);
            this.pnlChart2.TabIndex = 5;
            // 
            // chartSanPham
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSanPham.ChartAreas.Add(chartArea2);
            this.chartSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartSanPham.Legends.Add(legend2);
            this.chartSanPham.Location = new System.Drawing.Point(0, 0);
            this.chartSanPham.Name = "chartSanPham";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSanPham.Series.Add(series2);
            this.chartSanPham.Size = new System.Drawing.Size(520, 420);
            this.chartSanPham.TabIndex = 0;
            this.chartSanPham.Text = "chart2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1127, 750);
            this.Controls.Add(this.pnlChart2);
            this.Controls.Add(this.pnlChart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlKH);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKH.ResumeLayout(false);
            this.pnlKH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlChart1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.pnlChart2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Panel pnlKH;
        private System.Windows.Forms.Label lblIconKH;
        private System.Windows.Forms.Label lblTongKH;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTongSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblIconSP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.Label lblIconHD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblIconDT;
        private System.Windows.Forms.Panel pnlChart1;
        private System.Windows.Forms.Panel pnlChart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSanPham;
    }
}