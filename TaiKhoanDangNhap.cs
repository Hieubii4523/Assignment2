using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class TaiKhoanDangNhap
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public TaiKhoan TaiKhoan { get; set; }

        public List<TaiKhoanDangNhap> danhSachTaiKhoan = new List<TaiKhoanDangNhap>();
    }
}
