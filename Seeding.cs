using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Seeding
    {
        public static List<TaiKhoanDangNhap> dSTaiKhoan
        {
            get
            {
                return new List<TaiKhoanDangNhap>()
                {
                    new TaiKhoanDangNhap
                    {
                        Username = "hieu1",
                        Password = "1",
                        TaiKhoan = new TaiKhoan
                        {
                            SoTaiKhoan = "123",
                            SoDu = 500000,
                            TrangThai = true,
                            ChuTaiKhoan = new KhachHang
                               {
                                Id = 1,
                                Ten = "Ngoc Hieu1",
                                GioiTinh = true,
                                NgaySinh = new DateTime(2006, 2, 3),
                                SDT = "0987654321",
                                SoCCCD = "0987654321"
                            }
                        }
                    },
                    new TaiKhoanDangNhap
                    {
                        Username = "hieu2",
                        Password = "2",
                        TaiKhoan = new TaiKhoan
                        {
                            SoTaiKhoan = "234",
                            SoDu = 1000000,
                            TrangThai = true,
                            ChuTaiKhoan = new KhachHang
                            {
                                Id = 2,
                                Ten = "Ngoc Hieu2",
                                GioiTinh = false,
                                NgaySinh = new DateTime(2006, 2, 3),
                                SDT = "0123456789",
                                SoCCCD = "0123456789"
                            }
                        }
                    },
                    new TaiKhoanDangNhap
                    {
                        Username = "hieu3",
                        Password = "3",
                        TaiKhoan = new TaiKhoan
                        {
                            SoTaiKhoan = "345",
                            SoDu = 300000,
                            TrangThai = false,
                            ChuTaiKhoan = new KhachHang
                            {
                                Id = 3,
                                Ten = "Ngoc Hieu3",
                                GioiTinh = true,
                                NgaySinh = new DateTime(2006, 2, 3),
                                SDT = "5432167890",
                                SoCCCD = "5432167890"
                            }
                        }
                    }
                };
            }
        }
    }
}
