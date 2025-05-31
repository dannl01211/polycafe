using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSTheLuuDong
    {
        DALTheLuuDong dALTheLuuDong = new DALTheLuuDong();

        public List<TheLuuDong> GetTheLuuDongList()
        {
            return dALTheLuuDong.selectAll();
        }

        public string InsertTheLuuDong(TheLuuDong tld)
        {
            try
            {
                tld.MaThe = dALTheLuuDong.generateMaThe();
                if (string.IsNullOrEmpty(tld.MaThe))
                {
                    return "Mã thẻ không hợp lệ";
                }
                dALTheLuuDong.insertTheLuuDong(tld);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateTheLuuDong(TheLuuDong tld)
        {
            try
            {
                if (string.IsNullOrEmpty(tld.MaThe))
                {
                    return "Mã thẻ không hợp lệ";
                }
                dALTheLuuDong.updateTheLuuDong(tld);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteTheLuuDong(string maThe)
        {
            try
            {
                if (string.IsNullOrEmpty(maThe))
                {
                    return "Mã thẻ không hợp lệ";
                }
                dALTheLuuDong.deleteTheLuuDong(maThe);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
