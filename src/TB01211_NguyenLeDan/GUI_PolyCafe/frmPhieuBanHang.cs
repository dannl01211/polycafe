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
using UTIL_PolyCafe;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class frmPhieuBanHang : Form
    {
        private bool isLoadingTheLuuDongData = true;
        BUSPhieuBanHang busPhieuBanHang = new BUSPhieuBanHang();
        public frmPhieuBanHang()
        {
            InitializeComponent();
        }

        private void frmPhieuBanHang_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadNhanVien();
            LoadTheLuuDong();
            LoadDanhSachPhieu("");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClearForm(string msThe)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaPhieu.Clear();
            cboMaNhanVien.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdoChoXacNhan.Enabled = true;
            rdoDaThanhToan.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdoChoXacNhan.Checked = true;
        }

        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboMaNhanVien.Enabled = false;
                }
                cboMaNhanVien.DataSource = dsLoai;
                cboMaNhanVien.ValueMember = "MaNhanVien";
                cboMaNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaThe.DataSource = lst;
            cboMaThe.ValueMember = "MaThe";
            cboMaThe.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }

        private void LoadDanhSachPhieu(string maThe)
        {
            BUSPhieuBanHang busPhieuBanHang = new BUSPhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboMaNhanVien.Enabled = false;
            }
            dgvPhieuBanHang.DataSource = lst;


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút

            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!dgvPhieuBanHang.Columns.Contains("ThanhToan"))
            {
                dgvPhieuBanHang.Columns.Add(buttonColumn);
            }
            dgvPhieuBanHang.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPhieuBanHang.RowTemplate.Height = 50;

            dgvPhieuBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPhieuBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieu = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaPhieu"].Value.ToString();
            string maThe = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaThe"].Value.ToString();
            string maNhanVien = dgvPhieuBanHang.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();
            PhieuBanHang phieu = (PhieuBanHang)dgvPhieuBanHang.CurrentRow.DataBoundItem;
            TheLuuDong the = new TheLuuDong();
            NhanVien nv = new NhanVien();
            foreach (TheLuuDong item in cboMaThe.Items)
            {
                if (item.MaThe == maThe)
                {
                    the = item;
                    break;
                }
            }
            foreach (NhanVien item in cboMaNhanVien.Items)
            {
                if (item.MaNhanVien == maNhanVien)
                {
                    nv = item;
                    break;
                }
            }
            frmChiTietPhieu frm = new frmChiTietPhieu(the, phieu, nv);
            frm.ShowDialog();


        }

        private void dgvPhieuBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoadingTheLuuDongData = true;
            DataGridViewRow row = dgvPhieuBanHang.Rows[e.RowIndex];
            cboMaThe.SelectedValue = row.Cells["MaThe"].Value.ToString();
            cboMaNhanVien.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
            dtpNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
            txtMaPhieu.Text = row.Cells["MaPhieu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdoDaThanhToan.Checked = true;
                rdoDaThanhToan.Enabled = false;
                rdoChoXacNhan.Enabled = false;
                cboMaNhanVien.Enabled = false;
                dtpNgayTao.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            else
            {
                rdoDaThanhToan.Checked = false;
                rdoDaThanhToan.Enabled = true;
                rdoChoXacNhan.Enabled = true;
                cboMaNhanVien.Enabled = true;
                rdoChoXacNhan.Checked = true;
                rdoChoXacNhan.Enabled = true;
                dtpNgayTao.Enabled = true;
                // Bật nút "Sửa"
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maThe = cboMaThe.SelectedValue?.ToString();
                string maNhanVien = cboMaNhanVien.SelectedValue?.ToString();
                DateTime ngayTao = dtpNgayTao.Value;
                bool trangThai;
                if (rdoChoXacNhan.Checked)
                {
                    trangThai = false;
                }
                else
                {
                    trangThai = true;
                }
                if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhieuBanHang phieu = new PhieuBanHang
                {
                    // Mã phiếu sẽ được tự động sinh
                    MaThe = maThe,
                    MaNhanVien = maNhanVien,
                    NgayTao = ngayTao,
                    TrangThai = trangThai
                };
                busPhieuBanHang.InsertPhieuBanHang(phieu);
                MessageBox.Show("Thêm mới phiếu bán hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(maThe);
                LoadDanhSachPhieu(maThe);
                LoadNhanVien();
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu bán hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = txtMaPhieu.Text.Trim();
                string maThe = cboMaThe.SelectedValue?.ToString();
                string maNhanVien = cboMaNhanVien.SelectedValue?.ToString();
                DateTime ngayTao = dtpNgayTao.Value;
                bool trangThai;
                if (rdoChoXacNhan.Checked)
                {
                    trangThai = false;
                }
                else
                {
                    trangThai = true;
                }
                if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng không để trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhieuBanHang phieu = new PhieuBanHang
                {
                    MaPhieu = maPhieu,
                    MaThe = maThe,
                    MaNhanVien = maNhanVien,
                    NgayTao = ngayTao,
                    TrangThai = trangThai
                };
                busPhieuBanHang.UpdatePhieuBanHang(phieu);
                MessageBox.Show("Cập nhật phiếu bán hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(maThe);
                LoadDanhSachPhieu(maThe);
                LoadNhanVien();
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phiếu bán hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ClearForm("");
            LoadDanhSachPhieu("");
            LoadNhanVien();
            LoadTheLuuDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = txtMaPhieu.Text.Trim();
                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Vui lòng chọn phiếu bán hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu bán hàng này không?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    busPhieuBanHang.DeletePhieuBanHang(maPhieu);
                    MessageBox.Show("Xóa phiếu bán hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm("");
                    LoadDanhSachPhieu("");
                    LoadNhanVien();
                    LoadTheLuuDong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phiếu bán hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

