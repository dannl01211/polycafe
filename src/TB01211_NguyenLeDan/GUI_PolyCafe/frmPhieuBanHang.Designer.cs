namespace GUI_PolyCafe
{
    partial class frmPhieuBanHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdoChoXacNhan = new System.Windows.Forms.RadioButton();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaThe = new System.Windows.Forms.ComboBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhieuBanHang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(546, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU BÁN HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã thẻ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdoDaThanhToan);
            this.groupBox1.Controls.Add(this.rdoChoXacNhan);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.cboMaThe);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // rdoDaThanhToan
            // 
            this.rdoDaThanhToan.AutoSize = true;
            this.rdoDaThanhToan.Location = new System.Drawing.Point(323, 178);
            this.rdoDaThanhToan.Name = "rdoDaThanhToan";
            this.rdoDaThanhToan.Size = new System.Drawing.Size(134, 24);
            this.rdoDaThanhToan.TabIndex = 9;
            this.rdoDaThanhToan.TabStop = true;
            this.rdoDaThanhToan.Text = "Đã thanh toán";
            this.rdoDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdoChoXacNhan
            // 
            this.rdoChoXacNhan.AutoSize = true;
            this.rdoChoXacNhan.Location = new System.Drawing.Point(149, 180);
            this.rdoChoXacNhan.Name = "rdoChoXacNhan";
            this.rdoChoXacNhan.Size = new System.Drawing.Size(132, 24);
            this.rdoChoXacNhan.TabIndex = 8;
            this.rdoChoXacNhan.TabStop = true;
            this.rdoChoXacNhan.Text = "Chờ xác nhận";
            this.rdoChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Location = new System.Drawing.Point(463, 113);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(235, 27);
            this.dtpNgayTao.TabIndex = 7;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(149, 112);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(202, 28);
            this.cboMaNhanVien.TabIndex = 6;
            // 
            // cboMaThe
            // 
            this.cboMaThe.FormattingEnabled = true;
            this.cboMaThe.Location = new System.Drawing.Point(463, 45);
            this.cboMaThe.Name = "cboMaThe";
            this.cboMaThe.Size = new System.Drawing.Size(223, 28);
            this.cboMaThe.TabIndex = 5;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(127, 40);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(203, 27);
            this.txtMaPhieu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(378, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày tạo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(821, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(62, 177);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(233, 27);
            this.txtTim.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(325, 156);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 48);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(371, 46);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(113, 40);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(137, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(253, 47);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(137, 46);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 37);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(14, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhieuBanHang
            // 
            this.dgvPhieuBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuBanHang.Location = new System.Drawing.Point(3, 340);
            this.dgvPhieuBanHang.Name = "dgvPhieuBanHang";
            this.dgvPhieuBanHang.RowHeadersWidth = 51;
            this.dgvPhieuBanHang.RowTemplate.Height = 24;
            this.dgvPhieuBanHang.Size = new System.Drawing.Size(1316, 352);
            this.dgvPhieuBanHang.TabIndex = 3;
            this.dgvPhieuBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuBanHang_CellClick);
            this.dgvPhieuBanHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuBanHang_CellDoubleClick);
            // 
            // frmPhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.Brown_Beige_Cream_Modern_Illustration_Coffee_Project_Presentation8;
            this.ClientSize = new System.Drawing.Size(1319, 695);
            this.Controls.Add(this.dgvPhieuBanHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuBanHang";
            this.Text = "frmPhieuBanHang";
            this.Load += new System.EventHandler(this.frmPhieuBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDaThanhToan;
        private System.Windows.Forms.RadioButton rdoChoXacNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaThe;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhieuBanHang;
    }
}