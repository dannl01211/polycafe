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
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmDoiMK : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frmDoiMK()
        {
            InitializeComponent();
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin()) 
            {
                txtMaNV.Text = AuthUtil.user.MaNhanVien;
                txtTenNV.Text = AuthUtil.user.HoTen;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text)) 
            {
                MessageBox.Show(this, "Mật khẩu cũ không đúng??", "Và Đây Là 1 Sai Lầm Nghiêm Trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                if (!txtMatKhauMoi.Text.Equals(txtXacNhanMK.Text))
                {
                    MessageBox.Show(this, "Xác nhận mật khẩu mới chưa trùng khớp!?");
                }
                else 
                { 
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;
                    if(busNhanVien.ResetMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại kiểm tra lại ngay*");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMatKhauCu_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = cbMatKhauCu.Checked ? '\0' : '*';
        }

        private void cbMatKhauMoi_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = cbMatKhauMoi.Checked ? '\0' : '*';
        }

        private void cbXacNhanMK_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.PasswordChar = cbXacNhanMK.Checked ? '\0' : '*';
        }
    }
}
