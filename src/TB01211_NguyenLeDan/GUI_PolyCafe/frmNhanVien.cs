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
    public partial class frmNhanVien : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            LoadDanhSachNhanVien();
        }
        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien bUSNhanVien = new BUSNhanVien();
            dgvDSNV.DataSource = null;
            dgvDSNV.DataSource = bUSNhanVien.GetNhanVienList();
            
        }
        private void ClearForm() 
        {
            txtMaNhanVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtMatKhau.Clear();
            txtXNMatKhau.Clear();
            txtEmail.Clear();
            rdoNhanVien.Checked = true;
            rdoHoatDong.Checked = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy dữ liệu từ form
                
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                bool vaiTro = rdoQuanLy.Checked;  // Nếu là Trưởng phòng
                bool trangThai = rdoHoatDong.Checked; // Nếu được check là đang active

                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != txtXNMatKhau.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Bước 3: Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai
                };

                // Bước 4: Thêm vào CSDL
                busNhanVien.InsertNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm(); // Xóa form sau khi thêm
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                
                bool vaiTro = rdoQuanLy.Checked;  // Nếu là Trưởng phòng
                bool trangThai = rdoHoatDong.Checked; // Nếu được check là đang active
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (matKhau != txtXNMatKhau.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Bước 3: Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai
                };
                // Bước 4: Cập nhật vào CSDL
                busNhanVien.UpdateNhanVien(nv);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi cập nhật
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thoát",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmNhanVien_DoubleClick(object sender, EventArgs e)
        {


        }

        private void dgvDSNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtXNMatKhau.Text = row.Cells["MatKhau"].Value.ToString();

                bool vaiTro = Convert.ToBoolean(row.Cells["VaiTro"].Value);
                if (vaiTro == false)
                {
                    rdoNhanVien.Checked = true;
                }
                else
                {
                    rdoQuanLy.Checked = true;
                }
                bool trangthai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                if (trangthai == false)
                {
                    rdoHoatDong.Checked = true;
                }
                else
                {
                    rdoTamNgung.Checked = true;
                }
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy mã nhân viên từ form
                string maNV = txtMaNhanVien.Text.Trim();
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Bước 3: Xóa nhân viên khỏi CSDL
                busNhanVien.DeleteNhanVien(maNV);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi xóa
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
