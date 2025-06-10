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
    public partial class frmLoaiSanPham : Form
    {
        BUSLoaiSanPham busLoaiSanPham = new BUSLoaiSanPham();
        
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void LoadDanhSachLoaiSP() 
        {
            BUSLoaiSanPham busLoaiSanPham = new BUSLoaiSanPham();
            dgvDSLoaiSP.DataSource = null;
            dgvDSLoaiSP.DataSource = busLoaiSanPham.GetLoaiSanPhamList();
            
        }
        private void ClearForm() 
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            txtGhiChu.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void dgvDSLoaiSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSLoaiSP.Rows[e.RowIndex];
            txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                string tenLoai = txtTenLoai.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();
                if (string.IsNullOrEmpty(ghiChu) || string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoaiSanPham loaisp = new LoaiSanPham
                {
                    
                    TenLoai = tenLoai,
                    GhiChu = ghiChu
                };
                busLoaiSanPham.InsertLoaiSanPham(loaisp);
                MessageBox.Show("Thêm loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                string maLoai = txtMaLoai.Text.Trim();
                string tenLoai = txtTenLoai.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();
                if (string.IsNullOrEmpty(ghiChu) || string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoaiSanPham loaisp = new LoaiSanPham
                {
                    MaLoai = maLoai,
                    TenLoai = tenLoai,
                    GhiChu = ghiChu
                };
                busLoaiSanPham.UpdateLoaiSanPham(loaisp);
                MessageBox.Show("Cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string maLoai = txtMaLoai.Text.Trim();
                if (string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    busLoaiSanPham.DeleteLoaiSanPham(maLoai);
                    MessageBox.Show("Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
