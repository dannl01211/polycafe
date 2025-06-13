namespace GUI_PolyCafe
{
    partial class frmTheLuuDong
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
            this.txtChuSoHuu = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDSTheLuuDong = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbHoatDong = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheLuuDong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChuSoHuu
            // 
            this.txtChuSoHuu.BackColor = System.Drawing.Color.White;
            this.txtChuSoHuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuSoHuu.Location = new System.Drawing.Point(250, 151);
            this.txtChuSoHuu.Name = "txtChuSoHuu";
            this.txtChuSoHuu.Size = new System.Drawing.Size(296, 30);
            this.txtChuSoHuu.TabIndex = 31;
            // 
            // txtMaThe
            // 
            this.txtMaThe.BackColor = System.Drawing.Color.White;
            this.txtMaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThe.Location = new System.Drawing.Point(250, 86);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(296, 30);
            this.txtMaThe.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Chủ sở hữu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã thẻ";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.Color.White;
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(1171, 145);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(121, 43);
            this.btnLammoi.TabIndex = 37;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(873, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 43);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1021, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 43);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(873, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 43);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(729, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 43);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDSTheLuuDong
            // 
            this.dgvDSTheLuuDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTheLuuDong.Location = new System.Drawing.Point(2, 273);
            this.dgvDSTheLuuDong.Name = "dgvDSTheLuuDong";
            this.dgvDSTheLuuDong.RowHeadersWidth = 51;
            this.dgvDSTheLuuDong.RowTemplate.Height = 24;
            this.dgvDSTheLuuDong.Size = new System.Drawing.Size(1315, 420);
            this.dgvDSTheLuuDong.TabIndex = 41;
            this.dgvDSTheLuuDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTheLuuDong_CellDoubleClick);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(1156, 80);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 36);
            this.btnTim.TabIndex = 40;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.White;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(850, 86);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(252, 30);
            this.txtTim.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(566, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "THẺ LƯU ĐỘNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Trạng thái";
            // 
            // cbHoatDong
            // 
            this.cbHoatDong.AutoSize = true;
            this.cbHoatDong.BackColor = System.Drawing.Color.Transparent;
            this.cbHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoatDong.Location = new System.Drawing.Point(250, 216);
            this.cbHoatDong.Name = "cbHoatDong";
            this.cbHoatDong.Size = new System.Drawing.Size(124, 29);
            this.cbHoatDong.TabIndex = 22;
            this.cbHoatDong.Text = "Hoạt động";
            this.cbHoatDong.UseVisualStyleBackColor = false;
            // 
            // frmTheLuuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_PolyCafe.Properties.Resources.Brown_Beige_Cream_Modern_Illustration_Coffee_Project_Presentation10;
            this.ClientSize = new System.Drawing.Size(1319, 695);
            this.Controls.Add(this.cbHoatDong);
            this.Controls.Add(this.dgvDSTheLuuDong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtChuSoHuu);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "frmTheLuuDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTheLuuDong";
            this.Load += new System.EventHandler(this.frmTheLuuDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTheLuuDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChuSoHuu;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDSTheLuuDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbHoatDong;
    }
}