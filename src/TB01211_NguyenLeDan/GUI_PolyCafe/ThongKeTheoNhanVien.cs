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
using System.Windows.Forms.DataVisualization.Charting;
using BLL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class ThongKeTheoNhanVien : Form
    {
        public ThongKeTheoNhanVien()
        {
            InitializeComponent();
        }

        private void ThongKeTheoNhanVien_Load(object sender, EventArgs e)
        {
            thongkeNhanVien();
            LoadNhanVien();
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }
        // GUI_PolyCafe/frmThongKe.cs (add to your form)
        private BUS_ThongKeNhanVien ThongKeNhanVien = new BUS_ThongKeNhanVien();
        private BUSNhanVien busNhanVien = new BUSNhanVien();
        private void thongkeNhanVien()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            List<ThongKeNhanVien> data = ThongKeNhanVien.GetThongKeDoanhThuNhanVien(tuNgay, denNgay);

            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhân viên trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Titles.Clear();
                return;
            }

            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add($"Doanh thu theo nhân viên\nTừ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy}");

            Series series = new Series("Doanh thu nhân viên");
            series.ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                series.Points.AddXY(item.HoTen, item.DoanhThu);
            }

            chartDoanhThu.Series.Add(series);
        }

        private void LoadNhanVien()
        {
            var dsNV = busNhanVien.GetNhanVienList();
            dsNV.Insert(0, new NhanVien { MaNhanVien = "", HoTen = "--Tất cả--" });
            cboTenNhanVien.DataSource = dsNV;
            cboTenNhanVien.DisplayMember = "HoTen";
            cboTenNhanVien.ValueMember = "MaNhanVien";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string tenNV = cboTenNhanVien.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(tenNV))
            {
                thongkeNhanVien();
            }
            else
            {
                LoadNhanVien();
            }
        }
    }
}
