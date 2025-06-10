using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUS_ThongKe
    {
        private DALThongKe dal = new DALThongKe();


        public List<ThongKe> GetThongKeDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoaiTheoNgay(tuNgay, denNgay);
        }
        public List<ThongKe> GetThongKeDoanhThuTheoLoai(string ma, DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoai(ma, tuNgay, denNgay);
        }

    }

}
