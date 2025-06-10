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
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
            CheckPermisson();
            
        }

        private void heejToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStripDoiMK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMK());

        }

        private Form currenFormChild;
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void openChildForm(Form formchild)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = formchild;
            formchild.TopLevel = false;
            formchild.FormBorderStyle = FormBorderStyle.None;
            formchild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formchild);
            pnMain.Tag = formchild;
            formchild.BringToFront();
            formchild.Show();
        }

        private void VaiTroNhanVien()
        {
            
            danhMucToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void CheckPermisson() 
        {
            if (AuthUtil.IsLogin())
            {
                danhMucToolStripMenuItem.Visible = true;
                banHangToolStripMenuItem.Visible = true;
                nhanVienToolStripMenuItem.Visible = true;
                doanhThuToolStripMenuItem.Visible = true;
                
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
            }
            else
            {
                heThongToolStripMenuItem.Visible = true;
                MenuStripDangXuat.Visible = false;
                MenuStripThongTinTK.Visible = false;
                danhMucToolStripMenuItem.Visible = false;
                banHangToolStripMenuItem.Visible = false;
                nhanVienToolStripMenuItem.Visible = false;
                doanhThuToolStripMenuItem.Visible = false;

            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTheLuuDong());
        }

        private void MenuStripSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBanHang());
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKeTheoNhanVien());
        }

        private void MenuStripDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản", "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
            {
                this.Close();
                return;
            }
            frmLogin login = new frmLogin();
            login.Show();

        }

        private void MenuStripThoat_Click(object sender, EventArgs e)
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

        private void MenuStripThongTinTK_Click(object sender, EventArgs e)
        {
            NhanVien nv = AuthUtil.user;
            frmThongTinTaiKhoan thongTinTaiKhoan = new frmThongTinTaiKhoan(nv);
            openChildForm(thongTinTaiKhoan);
        }
    }
}
