using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment2
{


    public class KhachHang
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string SoCCCD { get; set; }
        public enum LoaiGiaoDich
        {
            Nhan = 0,
            Gui = 1
        }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {Id}, Tên: {Ten}, Giới Tính: {(GioiTinh ? "Nam" : "Nữ")}, Ngày Sinh: {NgaySinh.ToShortDateString()}, SĐT: {SDT}, CCCD: {SoCCCD}");
        }
    }
}
