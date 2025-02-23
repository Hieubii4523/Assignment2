using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Assignment2.KhachHang;

namespace Assignment2
{

    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public TaiKhoan TaiKhoanGui { get; set; }
        public TaiKhoan TaiKhoanNhan { get; set; }
        public double SoTien { get; set; }
        public LoaiGiaoDich LoaiGiaoDich { get; set; }

        public void InThongTin()
        {
            if (LoaiGiaoDich == LoaiGiaoDich.Gui)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"Mã GD: {MaGiaoDich}, Tài Khoản Gửi: {TaiKhoanGui.SoTaiKhoan}, Tài Khoản Nhận: {TaiKhoanNhan.SoTaiKhoan}, Số tiền: {(LoaiGiaoDich == LoaiGiaoDich.Nhan ? "+" : "-")}{SoTien},Loại: {(LoaiGiaoDich == LoaiGiaoDich.Gui ? "Gửi" : "Nhận")}");
            Console.ResetColor();
        }
    }
}
