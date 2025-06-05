using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSLoaiSanPham
    {
        DALLoaiSanPham dalLoaiSanPham = new DALLoaiSanPham();

        public List<LoaiSanPham> GetLoaiSanPhamList()
        {
            return dalLoaiSanPham.selectAll();
        }

        public string InsertLoaiSanPham(LoaiSanPham loaisp) 
        {
            try
            {
                loaisp.MaLoai = dalLoaiSanPham.generateLoaiSanPham();
                if(string.IsNullOrEmpty(loaisp.MaLoai))
                { 
                    return "Mã loại sản phẩm không hợp lệ";
                }
                dalLoaiSanPham.insertLoaiSanPham(loaisp);
                return string.Empty;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateLoaiSanPham(LoaiSanPham loaisp)
        {
            try
            {
                if (string.IsNullOrEmpty(loaisp.MaLoai))
                {
                    return "Mã loại sản phẩm không hợp lệ";
                }
                dalLoaiSanPham.updateLoaiSanPham(loaisp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteLoaiSanPham(string maLoai)
        {
            try
            {
                if (string.IsNullOrEmpty(maLoai))
                {
                    return "Mã loại sản phẩm không hợp lệ";
                }
                dalLoaiSanPham.deleteLoaiSanPham(maLoai);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
