using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;

namespace DAL_PolyCafe
{
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email =@0 AND MatKhau =@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DBUtil.Value<NhanVien>(sql, thamSo);
            return nv;
        }

        public void UpdateMatKhau(string mk, string email)
        {
            try
            {
                string sql = "Update NhanVien Set MatKhau =@0 Where Email = @1";
                List<object> thamSo = new List<object>();
                thamSo.Add(mk);
                thamSo.Add(email);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void insertNhanVien(NhanVien nv) 
        {
            try
            {
                string sql = "INSERT INTO NhanVien (MaNhanVien, HoTen, MatKhau, Email, VaiTro, TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>();
                thamSo.Add(nv.MaNhanVien);
                thamSo.Add(nv.HoTen);
                thamSo.Add(nv.MatKhau);
                thamSo.Add(nv.Email);
                thamSo.Add(nv.VaiTro);
                thamSo.Add(nv.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateNhanVien(NhanVien nv)
        {
            try
            {
                string sql = "UPDATE NhanVien SET HoTen = @0, MatKhau = @1, Email = @2, VaiTro = @3, TrangThai = @4 WHERE MaNhanVien = @5";
                List<object> thamSo = new List<object>();
                thamSo.Add(nv.HoTen);
                thamSo.Add(nv.MatKhau);
                thamSo.Add(nv.Email);
                thamSo.Add(nv.VaiTro);
                thamSo.Add(nv.TrangThai);
                thamSo.Add(nv.MaNhanVien);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void deleteNhanVien(string maNV)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNV);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<NhanVien> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNhanVien = reader.GetString(0);
                    entity.HoTen = reader.GetString(1);
                    entity.Email = reader.GetString(2);
                    entity.MatKhau = reader.GetString(3);
                    entity.VaiTro = reader.GetBoolean(4);
                    entity.TrangThai = reader.GetBoolean(5);
                    //entity.MaNhanVien = reader["MaNhanVien"].ToString();
                    //entity.HoTen = reader["HoTen"].ToString();
                    //entity.Email = reader["Email"].ToString();
                    //entity.MatKhau = reader["MatKhau"].ToString();
                    //bool.Parse(reader["VaiTro"].ToString());
                    //bool.Parse(reader["TrangThai"].ToString());
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }
        public List<NhanVien> selectAll()
        {
            string sql = "SELECT * FROM NhanVien";
            return SelectBySql(sql, new List<object>());
        }
        
        public NhanVien selectById(string id)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);

            List<NhanVien> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNhanVien) FROM NhanVien";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public bool checkEmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }
    }
}

