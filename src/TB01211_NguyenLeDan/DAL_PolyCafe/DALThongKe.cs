using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;

namespace DAL_PolyCafe
{
    public class DALThongKe // Changed from 'internal' to 'public'  
    {
        public List<ThongKe> GetDoanhThuTheoLoaiTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            List<ThongKe> list = new List<ThongKe>();
            string sql = @"SELECT l.TenLoai, SUM(ctp.SoLuong * ctp.DonGia) AS TongDoanhThu
                    FROM ChiTietPhieu ctp
                    JOIN SanPham sp ON ctp.MaSanPham = sp.MaSanPham
                    JOIN LoaiSanPham l ON sp.MaLoai = l.MaLoai
                    JOIN PhieuBanHang p ON ctp.MaPhieu = p.MaPhieu
                    WHERE p.NgayTao BETWEEN @0 AND (SELECT MAX(NgayTao) FROM PhieuBanHang)
                    GROUP BY l.TenLoai;
                    ";

            List<object> parameters = new List<object> { tuNgay, denNgay };
            SqlDataReader reader = DBUtil.Query(sql, parameters);

            while (reader.Read())
            {
                ThongKe item = new ThongKe();
                item.TenLoai = reader.GetString(0);
                item.DoanhThu = reader.GetDecimal(1);
                list.Add(item);
            }

            return list;
        }
        //thôgs kê theo loại 
        public List<ThongKe> GetDoanhThuTheoLoai(string maLoai, DateTime tuNgay, DateTime denNgay)
        {
            List<ThongKe> list = new List<ThongKe>();

            string sql = @"
                    SELECT 
                        sp.TenSanPham,
                        SUM(ctp.SoLuong * ctp.DonGia) AS TongTien
                    FROM ChiTietPhieu ctp
                    JOIN SanPham sp ON ctp.MaSanPham = sp.MaSanPham
                    JOIN LoaiSanPham lsp ON sp.MaLoai = lsp.MaLoai
                    JOIN PhieuBanHang pbh ON ctp.MaPhieu = pbh.MaPhieu
                    WHERE sp.MaLoai = @0 AND pbh.NgayTao BETWEEN @1 AND @2
                    GROUP BY sp.TenSanPham";

            List<object> parameters = new List<object> { maLoai, tuNgay, denNgay };

            SqlDataReader reader = DBUtil.Query(sql, parameters);

            while (reader.Read())
            {
                ThongKe item = new ThongKe
                {
                    TenLoai = reader["TenSanPham"].ToString(),
                    DoanhThu = reader.GetDecimal(reader.GetOrdinal("TongTien"))
                };

                list.Add(item);
            }

            return list;
        }
    }
}
