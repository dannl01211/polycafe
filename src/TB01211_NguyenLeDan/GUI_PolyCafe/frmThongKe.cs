
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
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmThongKe : Form
    {
        BUS_ThongKe ThongKe = new BUS_ThongKe();
        BUSLoaiSanPham LoaiSanPham = new BUSLoaiSanPham();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void thongke()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            List<ThongKe> data = ThongKe.GetThongKeDoanhThuTheoNgay(tuNgay, denNgay);

            // Kiểm tra dữ liệu rỗng
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                return;
            }

            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add($"Doanh thu theo loại sản phẩm\nTừ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}");

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.TenLoai, item.DoanhThu);
            }

            chartDoanhThu.Series.Add(series);
        }
        private void loadcbo()
        {
            List<LoaiSanPham> lst = LoaiSanPham.GetLoaiSanPhamList();
            lst.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = string.Format("--Tất Cả--") });
            cboLoaiSanPham.DataSource = lst;
            cboLoaiSanPham.ValueMember = "MaLoai";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        private void load()
        {
            if (cboLoaiSanPham.SelectedValue != null)
            {
                string maLoai = cboLoaiSanPham.SelectedValue.ToString();
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;

                var data = ThongKe.GetThongKeDoanhThuTheoLoai(maLoai, tuNgay, denNgay);

                chartDoanhThu.Series.Clear();
                chartDoanhThu.ChartAreas.Clear();
                chartDoanhThu.Titles.Clear();

                ChartArea area = new ChartArea("Area1");
                chartDoanhThu.ChartAreas.Add(area);

                Series series = new Series("Doanh Thu");
                series.ChartType = SeriesChartType.Column;
                series.XValueType = ChartValueType.String;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.TenLoai, item.DoanhThu);
                }

                chartDoanhThu.Series.Add(series);
                chartDoanhThu.Titles.Add("Biểu đồ doanh thu theo sản phẩm");
            }
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadcbo();
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maLoai = cboLoaiSanPham.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maLoai))
            {
                thongke();
            }
            else
            {
                load();
            }
        }
    }
}
