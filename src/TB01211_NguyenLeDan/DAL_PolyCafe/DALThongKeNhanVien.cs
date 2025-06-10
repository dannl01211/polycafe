
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_PolyCafe;

public class DALThongKeNhanVien
{
    // Adjust connection string as needed
    private string connectionString = @"Data Source=LAPCUATI;Initial Catalog=PolyCafe;Integrated Security=True;Trust Server Certificate=True";

    public List<ThongKeNhanVien> GetDoanhThuTheoNhanVien(DateTime tuNgay, DateTime denNgay)
    {
        List<ThongKeNhanVien> result = new List<ThongKeNhanVien>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
    SELECT nv.HoTen, SUM(ctp.SoLuong * ctp.DonGia) AS TongDoanhThu
    FROM ChiTietPhieu ctp
    JOIN PhieuBanHang pbh ON ctp.MaPhieu = pbh.MaPhieu
    JOIN NhanVien nv ON pbh.MaNhanVien = nv.MaNhanVien
    WHERE pbh.NgayTao BETWEEN @TuNgay AND @DenNgay
    GROUP BY nv.HoTen
";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@DenNgay", denNgay);


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new ThongKeNhanVien
                {
                    HoTen = reader["HoTen"].ToString(),
                    DoanhThu = reader.GetDecimal(reader.GetOrdinal("TongDoanhThu"))
                });
            }
        }
        return result;
    }
}
