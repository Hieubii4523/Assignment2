using System;
using System.Text;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Program
    {
        public static bool IsLogin;
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            TaiKhoanDangNhap dSTaiKhoan = new TaiKhoanDangNhap();
            TaiKhoanDangNhap taiKhoanDangNhap = null;
            dSTaiKhoan.danhSachTaiKhoan = Seeding.dSTaiKhoan;
            while (true)
            {
            dangNhap: taiKhoanDangNhap = Logic.DangNhap(dSTaiKhoan);
                if (IsLogin)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("1. Hiển thị Thông tin Tài Khoản");
                        Console.WriteLine("2. Hiển Thị Thông Tin chủ tài khoản");
                        Console.WriteLine("3. Chuyển khoản đến số tài khoản khác");
                        Console.WriteLine("4. Hiển thị danh sách GiaoDich của tài khoản");
                        Console.WriteLine("5. Sao kê");
                        Console.WriteLine("6. Đăng xuất");
                    chonChucNang: Console.Write("Xin mời chọn chức năng: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (input)
                        {
                            case 1:
                                Logic.HienThiThongTinTaiKhoan(taiKhoanDangNhap);
                                break;
                            case 2:
                                Logic.HienThiThongTinChuTaiKhoan(taiKhoanDangNhap);
                                break;
                            case 3:
                                Logic.ChuyenKhoan(dSTaiKhoan, taiKhoanDangNhap);
                                break;
                            case 4:
                                Logic.HienThiDanhSachGiaoDich(taiKhoanDangNhap);
                                break;
                            case 5:
                                Logic.SaoKe(taiKhoanDangNhap);
                                break;
                            case 6:
                                Console.WriteLine();
                                Console.WriteLine("Đăng xuất thành công.");
                                Console.WriteLine();
                                goto dangNhap;
                            default:
                                goto chonChucNang;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Nhấn phím bất kì để quay lại menu...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Thông tin tài khoản hoặc mật khẩu không chính xác, xin vui lòng nhập lại!");
                    goto dangNhap;
                }
            }
        }
    }
}