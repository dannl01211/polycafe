using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSSanPham
    {
        DALSanPham dalSanPham = new DALSanPham();

        public List<SanPham> GetSanPhamList(int trangThai = -1)
        {
            return dalSanPham.selectAll(trangThai);
        }

        public string InsertSanPham(SanPham sp)
        {
            try
            {
                sp.MaSanPham = dalSanPham.generateMaSanPham();
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ";
                }
                dalSanPham.insertSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateSanPham(SanPham sp)
        {
            try
            {
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ";
                }
                dalSanPham.updateSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteSanPham(string maSanPham)
        {
            try
            {
                if (string.IsNullOrEmpty(maSanPham))
                {
                    return "Mã sản phẩm không hợp lệ";
                }
                dalSanPham.deleteSanPham(maSanPham);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
