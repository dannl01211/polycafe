
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL_PolyCafe;  

namespace GUI_PolyCafe
{
    public partial class frmThongKe : Form
    {
        
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            BUS_ThongKe bll = new BUS_ThongKe();
            lblSanPham.Text = bll.TongSanPham().ToString();
            lblNhanVien.Text = bll.TongNhanVien().ToString();
            lblDoanhThu.Text = bll.LayTongDoanhThu().ToString("N0") + " VND";

            dgvTheoLoai.DataSource = bll.LaySanPhamTheoLoai();
            chartDoanhThu.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            var data = bll.LayDoanhThuTheoNgay();
            foreach (var item in data)
            {
                series.Points.AddXY(((DateTime)item.Ngay).ToString("dd/MM/yyyy"), item.TongTien);
            }

            chartDoanhThu.Series.Add(series);
        }
    }
}
