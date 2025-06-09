using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;

namespace BLL_PolyCafe
{
    public class BLL_ThongKe
    {
        DALThongKe dal = new DALThongKe();

        public int TongSanPham()
        {
            return dal.DemSanPham();
        }

        public int TongNhanVien()
        {
            return dal.DemNhanVien();
        }

        public List<dynamic> LaySanPhamTheoLoai()
        {
            return dal.SanPhamTheoLoai();
        }

        public decimal LayTongDoanhThu()
        {
            return dal.TongDoanhThu();
        }
        public List<dynamic> LayDoanhThuTheoNgay()
        {
            return dal.DoanhThuTheoNgay();
        }

    }

}
