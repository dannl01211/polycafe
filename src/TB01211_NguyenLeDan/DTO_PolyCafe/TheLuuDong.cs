using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class TheLuuDong
    {
        public string MaThe { get; set; }
        public string ChuSoHuu { get; set; }

        public bool TrangThai { get; set; } = true;
        public string TrangThaiText => TrangThai ? "Hoạt động" : "Không hoạt động";

    }
}
