
using System;
using System.Collections.Generic;
using DTO_PolyCafe;

public class BUS_ThongKeNhanVien
{
    private DALThongKeNhanVien dal = new DALThongKeNhanVien();

    public List<ThongKeNhanVien> GetThongKeDoanhThuNhanVien(DateTime tuNgay, DateTime denNgay)
    {
        return dal.GetDoanhThuTheoNhanVien(tuNgay, denNgay);
    }
}
