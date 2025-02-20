using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TaiKhoan
    {
        public string SoTaiKhoan { get; set; }
        public double SoDu { get; set; }
        public bool TrangThai { get; set; }
        public List<GiaoDich> GiaoDichs { get; set; } = new List<GiaoDich>();
        public KhachHang ChuTaiKhoan { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"Số Tài Khoản: {SoTaiKhoan}, Số Dư: {SoDu}, Trạng Thái: {(TrangThai ? "Mở" : "Khoá")}");
        }
    }
}
