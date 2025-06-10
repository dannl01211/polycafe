using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan(NhanVien nv)
        {
            InitializeComponent();
            if (nv != null) 
            {
                txtMaNV.Text = nv.MaNhanVien;
                txtHoTen.Text = nv.HoTen;
                txtEmail.Text = nv.Email;
                txtMatkhau.Text = nv.MatKhau;
                txtVaiTro.Text = nv.VaiTro ? "Quản Lý" : "Nhân Viên";
                txtTrangThai.Text = nv.TrangThai ? "Đang Hoạt Động" : "Ngừng Hoạt Động";




            }
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void cboHienthi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatkhau.PasswordChar = cboHienthi.Checked ? '\0' : '*';
        }
    }
}
