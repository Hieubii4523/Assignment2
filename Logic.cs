using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Assignment2.KhachHang;
using static Assignment2.TaiKhoan;

namespace Assignment2
{
    internal class Logic
    {
        public static TaiKhoanDangNhap DangNhap(TaiKhoanDangNhap dSTaiKhoan)
        {
            Console.Write("Nhập Username: ");
            string user = Console.ReadLine();
            Console.Write("Nhập Password: ");
            string password = Console.ReadLine();
            foreach (var login in dSTaiKhoan.danhSachTaiKhoan)
            {
                if (user.Equals(login.Username, StringComparison.OrdinalIgnoreCase) && password.Equals(login.Password, StringComparison.OrdinalIgnoreCase))
                {
                    Program.IsLogin = true;
                    return login;
                    break;
                }
            }
            return null;
        }
        public static void HienThiThongTinTaiKhoan(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            taiKhoanDangNhap.TaiKhoan.InThongTin();
        }

        public static void HienThiThongTinChuTaiKhoan(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            taiKhoanDangNhap.TaiKhoan.ChuTaiKhoan.InThongTin();
        }

        public static void ChuyenKhoan(TaiKhoanDangNhap dSTaiKhoan, TaiKhoanDangNhap nguoiGui)
        {
        back: Console.Write("Nhập số tài khoản nhận: ");
            string stk = Console.ReadLine();
            if (stk.Equals("000"))
            {
                return;
            }
            TaiKhoanDangNhap nguoiNhan = null;
            foreach (var tk in dSTaiKhoan.danhSachTaiKhoan)
            {
                if (tk.TaiKhoan.SoTaiKhoan.Equals(stk))
                {
                    nguoiNhan = tk;
                    Console.WriteLine($"Chủ tài khoản: {tk.TaiKhoan.ChuTaiKhoan.Ten}");
                    break;
                }
            }
            if (nguoiNhan == null)
            {
                Console.WriteLine($"Không tìm thấy số tài khoản {stk}");
                goto back;
            }
            Console.Write("Nhập số tiền cần chuyển: ");
            double soTien = Convert.ToDouble(Console.ReadLine());
            if (!nguoiGui.TaiKhoan.TrangThai || !nguoiNhan.TaiKhoan.TrangThai || nguoiGui.TaiKhoan.SoDu < soTien || soTien <= 0)
            {
                Console.WriteLine($"Không thực hiện được giao dịch.");
                return;
            }
            nguoiGui.TaiKhoan.SoDu -= soTien;
            nguoiNhan.TaiKhoan.SoDu += soTien;
            Random rd = new Random();
            string maGiaoDich = rd.Next(100000, 1000000).ToString();
            GiaoDich giaoDichGui = new GiaoDich
            {
                MaGiaoDich = maGiaoDich,
                TaiKhoanGui = nguoiGui.TaiKhoan,
                TaiKhoanNhan = nguoiNhan.TaiKhoan,
                LoaiGiaoDich = LoaiGiaoDich.Gui
            };
            nguoiGui.TaiKhoan.GiaoDichs.Add(giaoDichGui);

            GiaoDich giaoDichNhan = new GiaoDich
            {
                MaGiaoDich = maGiaoDich,
                TaiKhoanGui = nguoiGui.TaiKhoan,
                TaiKhoanNhan = nguoiNhan.TaiKhoan,
                LoaiGiaoDich = LoaiGiaoDich.Nhan
            };
            nguoiNhan.TaiKhoan.GiaoDichs.Add(giaoDichNhan);
            Console.WriteLine("Giao dịch thành công!");
        }
        public static void HienThiDanhSachGiaoDich(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            if (taiKhoanDangNhap.TaiKhoan.GiaoDichs == null)
            {
                Console.WriteLine("Tài khoản chưa thực hiện giao dịch nào.");
            }
            Console.WriteLine("Danh sách giao dịch:");
            foreach (var giaoDich in taiKhoanDangNhap.TaiKhoan.GiaoDichs)
            {
                giaoDich.InThongTin();
            }
        }

        public static void SaoKe(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            string tenFile = $"SaoKe_{taiKhoanDangNhap.TaiKhoan.SoTaiKhoan}.txt";
            List<string> giaoDichStrings = new List<string>();

            foreach (var giaoDich in taiKhoanDangNhap.TaiKhoan.GiaoDichs)
            {
                string loaiGiaoDich = giaoDich.LoaiGiaoDich == LoaiGiaoDich.Gui ? "Gửi" : "Nhận";
                giaoDichStrings.Add($"Mã GD: {giaoDich.MaGiaoDich}, TK Gửi: {giaoDich.TaiKhoanGui.SoTaiKhoan}, TK Nhận: {giaoDich.TaiKhoanNhan.SoTaiKhoan}, Loại: {loaiGiaoDich}");
            }

            File.WriteAllLines(tenFile, giaoDichStrings);
            Console.WriteLine($"Sao kê đã được lưu vào file {tenFile}");
        }
    }
}
