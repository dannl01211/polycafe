namespace GUI_PolyCafe
{
    partial class frmSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.gbThongTinSP = new System.Windows.Forms.GroupBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.chbNgungBan = new System.Windows.Forms.CheckBox();
            this.chbHoatDong = new System.Windows.Forms.CheckBox();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbTacvu = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.gbThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.gbTacvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "SẢN PHẨM";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(48, 617);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(229, 27);
            this.txtTim.TabIndex = 12;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(161, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(288, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 35);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(411, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 35);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(533, 38);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(112, 35);
            this.btnLammoi.TabIndex = 19;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(533, 292);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(123, 37);
            this.btnChonAnh.TabIndex = 20;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(314, 607);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 37);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(759, 72);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 51;
            this.dgvDSSP.RowTemplate.Height = 24;
            this.dgvDSSP.Size = new System.Drawing.Size(557, 599);
            this.dgvDSSP.TabIndex = 23;
            this.dgvDSSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellDoubleClick);
            // 
            // gbThongTinSP
            // 
            this.gbThongTinSP.Controls.Add(this.cboMaLoai);
            this.gbThongTinSP.Controls.Add(this.chbNgungBan);
            this.gbThongTinSP.Controls.Add(this.chbHoatDong);
            this.gbThongTinSP.Controls.Add(this.btnChonAnh);
            this.gbThongTinSP.Controls.Add(this.picSanPham);
            this.gbThongTinSP.Controls.Add(this.txtDonGia);
            this.gbThongTinSP.Controls.Add(this.txtTenSP);
            this.gbThongTinSP.Controls.Add(this.txtMaSP);
            this.gbThongTinSP.Controls.Add(this.label7);
            this.gbThongTinSP.Controls.Add(this.label8);
            this.gbThongTinSP.Controls.Add(this.label9);
            this.gbThongTinSP.Controls.Add(this.label10);
            this.gbThongTinSP.Controls.Add(this.label11);
            this.gbThongTinSP.Location = new System.Drawing.Point(16, 82);
            this.gbThongTinSP.Name = "gbThongTinSP";
            this.gbThongTinSP.Size = new System.Drawing.Size(737, 379);
            this.gbThongTinSP.TabIndex = 24;
            this.gbThongTinSP.TabStop = false;
            this.gbThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(175, 237);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(252, 28);
            this.cboMaLoai.TabIndex = 26;
            // 
            // chbNgungBan
            // 
            this.chbNgungBan.AutoSize = true;
            this.chbNgungBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNgungBan.Location = new System.Drawing.Point(326, 292);
            this.chbNgungBan.Name = "chbNgungBan";
            this.chbNgungBan.Size = new System.Drawing.Size(111, 24);
            this.chbNgungBan.TabIndex = 25;
            this.chbNgungBan.Text = "Ngừng bán";
            this.chbNgungBan.UseVisualStyleBackColor = true;
            // 
            // chbHoatDong
            // 
            this.chbHoatDong.AutoSize = true;
            this.chbHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHoatDong.Location = new System.Drawing.Point(175, 292);
            this.chbHoatDong.Name = "chbHoatDong";
            this.chbHoatDong.Size = new System.Drawing.Size(108, 24);
            this.chbHoatDong.TabIndex = 24;
            this.chbHoatDong.Text = "Hoạt động";
            this.chbHoatDong.UseVisualStyleBackColor = true;
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(478, 36);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(229, 221);
            this.picSanPham.TabIndex = 21;
            this.picSanPham.TabStop = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(177, 168);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(250, 27);
            this.txtDonGia.TabIndex = 22;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(177, 105);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(250, 27);
            this.txtTenSP.TabIndex = 21;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(175, 39);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(252, 27);
            this.txtMaSP.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Trạng thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mã loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã sản phẩm";
            // 
            // gbTacvu
            // 
            this.gbTacvu.Controls.Add(this.btnLammoi);
            this.gbTacvu.Controls.Add(this.btnThoat);
            this.gbTacvu.Controls.Add(this.btnXoa);
            this.gbTacvu.Controls.Add(this.btnSua);
            this.gbTacvu.Controls.Add(this.btnThem);
            this.gbTacvu.Location = new System.Drawing.Point(16, 480);
            this.gbTacvu.Name = "gbTacvu";
            this.gbTacvu.Size = new System.Drawing.Size(674, 98);
            this.gbTacvu.TabIndex = 25;
            this.gbTacvu.TabStop = false;
            this.gbTacvu.Text = "Tác vụ";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(32, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 39);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 695);
            this.Controls.Add(this.gbTacvu);
            this.Controls.Add(this.gbThongTinSP);
            this.Controls.Add(this.dgvDSSP);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.gbThongTinSP.ResumeLayout(false);
            this.gbThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.gbTacvu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.GroupBox gbThongTinSP;
        private System.Windows.Forms.CheckBox chbNgungBan;
        private System.Windows.Forms.CheckBox chbHoatDong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbTacvu;
        private System.Windows.Forms.ComboBox cboMaLoai;
    }
}