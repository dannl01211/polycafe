using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmTheLuuDong : Form
    {
        BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();

        public frmTheLuuDong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadTheLuuDong();
            
        }

        private void LoadTheLuuDong() 
        {
            BUSTheLuuDong bUSTheLuuDong = new BUSTheLuuDong();
            dgvDSTheLuuDong.DataSource = null;
            dgvDSTheLuuDong.DataSource = bUSTheLuuDong.GetTheLuuDongList();
            dgvDSTheLuuDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtMaThe.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            cbHoatDong.Checked = true;
        }

        private void dgvDSTheLuuDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSTheLuuDong.Rows[e.RowIndex];
            txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
            txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maThe = txtMaThe.Text.Trim();
                
                string chuSoHuu = txtChuSoHuu.Text.Trim();
                if (string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Chủ sở hữu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool trangThai = cbHoatDong.Checked; // Nếu được check là đang active

                TheLuuDong tld = new TheLuuDong
                {
                    MaThe = maThe,
                    ChuSoHuu = chuSoHuu,
                    TrangThai = trangThai
                };
                busTheLuuDong.InsertTheLuuDong(tld);
                MessageBox.Show("Thêm thẻ lưu động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTheLuuDong();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi khi thêm thẻ lưu động: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maThe = txtMaThe.Text.Trim();
                if (string.IsNullOrEmpty(maThe))
                {
                    MessageBox.Show("Vui lòng chọn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                busTheLuuDong.DeleteTheLuuDong(maThe);
                MessageBox.Show("Xóa thẻ lưu động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTheLuuDong();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa thẻ lưu động: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                string maThe = txtMaThe.Text.Trim();
                string chuSoHuu = txtChuSoHuu.Text.Trim();
                if (string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Chủ sở hữu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool trangThai = cbHoatDong.Checked; // Nếu được check là đang active
                TheLuuDong tld = new TheLuuDong
                {
                    MaThe = maThe,
                    ChuSoHuu = chuSoHuu,
                    TrangThai = trangThai
                };
                busTheLuuDong.UpdateTheLuuDong(tld);
                MessageBox.Show("Cập nhật thẻ lưu động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thẻ lưu động: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadTheLuuDong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi cửa sổ", "Thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
