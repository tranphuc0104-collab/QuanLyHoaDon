namespace QuanLyHoaDon.Views
{
    partial class frmHoaDon
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 45);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 220);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(180, 140);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 33);
            this.cboKhachHang.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Khách hàng :";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLap.Location = new System.Drawing.Point(180, 90);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(250, 31);
            this.dtNgayLap.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ngày lập :";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(180, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(250, 27);
            this.txtMaHD.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã hóa đơn :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboSanPham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(580, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 220);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(430, 165);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(120, 40);
            this.btnThemSP.TabIndex = 42;
            this.btnThemSP.Text = "THÊM";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(170, 175);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(250, 27);
            this.txtThanhTien.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "Thành tiền :";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(170, 130);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 31);
            this.numSoLuong.TabIndex = 42;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Số lượng :";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(170, 85);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(250, 27);
            this.txtGiaBan.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Giá bán :";
            // 
            // cboSanPham
            // 
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(170, 40);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(250, 33);
            this.cboSanPham.TabIndex = 38;
            this.cboSanPham.SelectedIndexChanged += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Sản phẩm :";
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.AllowUserToAddRows = false;
            this.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(30, 340);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersVisible = false;
            this.dgvChiTietHD.RowHeadersWidth = 51;
            this.dgvChiTietHD.RowTemplate.Height = 24;
            this.dgvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHD.Size = new System.Drawing.Size(1150, 280);
            this.dgvChiTietHD.TabIndex = 28;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(930, 640);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(250, 38);
            this.txtTongTien.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(770, 640);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "TỔNG TIỀN :";
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuHD.FlatAppearance.BorderSize = 0;
            this.btnLuuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.ForeColor = System.Drawing.Color.White;
            this.btnLuuHD.Location = new System.Drawing.Point(30, 640);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(180, 50);
            this.btnLuuHD.TabIndex = 53;
            this.btnLuuHD.Text = "LƯU HÓA ĐƠN";
            this.btnLuuHD.UseVisualStyleBackColor = false;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1237, 730);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvChiTietHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLuuHD;
    }
}