using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO_PolyCafe;
using System.Data;

namespace DAL_PolyCafe
{
    public class DALSanPham
    {
        public string generateMaSanPham()
        {
            string prefix = "SP";
            string sql = "SELECT MAX(MaSanPham) FROM SanPham";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public void insertSanPham(SanPham sp)
        {
            try
            {
                string sql = @"INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, MaLoai, HinhAnh, TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>();
                thamSo.Add(sp.MaSanPham);
                thamSo.Add(sp.TenSanPham);
                thamSo.Add(sp.DonGia);
                thamSo.Add(sp.MaLoai);
                thamSo.Add(sp.HinhAnh);
                thamSo.Add(sp.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateSanPham(SanPham sp)
        {
            try
            {
                string sql = @"UPDATE SanPham SET TenSanPham = @0, DonGia = @1, MaLoai = @2, HinhAnh = @3, TrangThai = @4 Where MaSanPham = @5";
                List<object> thamSo = new List<object>();
                thamSo.Add(sp.TenSanPham);
                thamSo.Add(sp.DonGia);
                thamSo.Add(sp.MaLoai);
                thamSo.Add(sp.HinhAnh);
                thamSo.Add(sp.TrangThai);
                thamSo.Add(sp.MaSanPham);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void deleteSanPham(string maSanPham)
        {
            try
            {
                string sql = @"DELETE FROM SanPham WHERE MaSanPham = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maSanPham);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<SanPham> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<SanPham> list = new List<SanPham>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    SanPham entity = new SanPham();
                    entity.MaSanPham = reader.GetString(0);
                    entity.TenSanPham = reader.GetString(1);
                    entity.DonGia = reader.GetDecimal(2);
                    entity.MaLoai = reader.GetString(3);
                    entity.HinhAnh = reader.GetString(4);
                    entity.TrangThai = reader.GetBoolean(5);
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public SanPham selectById(string id)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSanPham = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<SanPham> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public List<SanPham> selectAll()
        {
            string sql = "SELECT * FROM SanPham";
            return SelectBySql(sql, new List<object>());
        }
    }
}
