using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmSanPham : Form
    {
        BUSSanPham busSanPham = new BUSSanPham();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadLoaiSanPham();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadLoaiSanPham() 
        {
            BUSLoaiSanPham bUSLoaiSanPham = new BUSLoaiSanPham();
            List<LoaiSanPham> loaiSanPhamList = bUSLoaiSanPham.GetLoaiSanPhamList();
            cboMaLoai.DataSource = loaiSanPhamList;
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";
        }
        private void LoadSanPham()
        {
            BUSSanPham bUSSanPham = new BUSSanPham();
            dgvDSSP.DataSource = null;
            dgvDSSP.DataSource = bUSSanPham.GetSanPhamList();
            dgvDSSP.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvDSSP.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvDSSP.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvDSSP.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvDSSP.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            dgvDSSP.Columns["TrangThai"].Visible = false; // Ẩn cột Trạng Thái
            dgvDSSP.Columns["HinhAnh"].HeaderText = "Hình Ảnh";

        }
        private void ClearForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            chbHoatDong.Checked = true;
            picSanPham.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {

                string tenSP = txtTenSP.Text.Trim();
                string donGiaSP = txtDonGia.Text.Trim();
                string maLoai = cboMaLoai.SelectedValue?.ToString();
                bool trangThai = chbHoatDong.Checked;
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaSP) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(donGiaSP, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string savedPath = ImageUtil.SaveImage(picSanPham.Image, "Uploads/SanPham");

                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savedPath,
                };
                busSanPham.InsertSanPham(sp);
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string donGiaSP = txtDonGia.Text.Trim();
                string maLoai = cboMaLoai.SelectedValue?.ToString();
                bool trangThai = chbHoatDong.Checked;

                if(chbHoatDong.Checked == false)
                {
                    trangThai = false;
                }
                else
                {
                    trangThai = true;
                }
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaSP) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(donGiaSP, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = ""
                };
                busSanPham.UpdateSanPham(sp);
                MessageBox.Show("Cập nhập sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    busSanPham.DeleteSanPham(maSP);
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadSanPham();
            LoadLoaiSanPham();
        }

        private void dgvDSSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSSP.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            string path = Path.Combine(Application.StartupPath, row.Cells["HinhAnh"].Value.ToString());
            picSanPham.Image = ImageUtil.LoadImage(path);
            picSanPham.Tag = path;
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            cboMaLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            if (trangThai)
            {
                chbHoatDong.Checked = true;
            }
            else
            {
                chbHoatDong.Checked = true;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picSanPham.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void SearchInAllCells(string keyword)
        {
            foreach (DataGridViewRow row in dgvDSSP.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword.ToLower()))
                    {

                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                SearchInAllCells(keyword);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtTim.Clear();
        }
    }
}
