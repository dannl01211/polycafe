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
    public class DALTheLuuDong
    {
        public string generateMaThe()
        {
            string prefix = "THE";
            string sql = "SELECT MAX(MaThe) FROM TheLuuDong";
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

        public void insertTheLuuDong(TheLuuDong tld)
        {
            try
            {
                string sql = @"INSERT INTO TheLuuDong (MaThe, ChuSoHuu, TrangThai) VALUES (@0, @1, @2)";
                List<object> thamSo = new List<object>();
                thamSo.Add(tld.MaThe);
                thamSo.Add(tld.ChuSoHuu);
                thamSo.Add(tld.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateTheLuuDong(TheLuuDong tld)
        {
            try
            {
                string sql = @"UPDATE TheLuuDong SET ChuSoHuu = @0, TrangThai = @1 Where MaThe = @2";
                List<object> thamSo = new List<object>();
                thamSo.Add(tld.ChuSoHuu);
                thamSo.Add(tld.TrangThai);
                thamSo.Add(tld.MaThe);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void deleteTheLuuDong(string maThe)
        {
            try
            {
                string sql = @"DELETE FROM TheLuuDong WHERE MaThe = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maThe);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<TheLuuDong> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<TheLuuDong> list = new List<TheLuuDong>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read()) 
                {
                    TheLuuDong entity = new TheLuuDong();
                    entity.MaThe = reader.GetString(0);
                    entity.ChuSoHuu = reader.GetString(1);
                    entity.TrangThai = reader.GetBoolean(2);
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public TheLuuDong selectById(string id)
        {
            string sql = "SELECT * FROM TheLuuDong WHERE MaThe = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<TheLuuDong> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public List<TheLuuDong> selectAll()
        {
            string sql = "SELECT * FROM TheLuuDong";
            return SelectBySql(sql, new List<object>());
        }
    }
}
