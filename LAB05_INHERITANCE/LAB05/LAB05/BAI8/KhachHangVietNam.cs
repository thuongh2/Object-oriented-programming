using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI8
{
    class KhachHangVietNam: HoaDon 
    {
        private string doiTuongKhachHang;
        private int dinhMuc;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                if (SoLuong < dinhMuc)
                    return thanhTien = SoLuong * DonGia;
                else
                    return thanhTien = SoLuong * DonGia * dinhMuc + (SoLuong - dinhMuc) * DonGia * 2.5;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap doi tuong khach hang (sinh hoat, kinh doanh, san xuat): ");
            doiTuongKhachHang = Console.ReadLine();
            Console.Write("Nhap Dinh Muc: ");
            dinhMuc = Convert.ToInt32(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Doi Tuong Khach Hang: {0}, Dinh Muc: {1}, Thanh Tien {2}", doiTuongKhachHang, dinhMuc, ThanhTien);
        }

    }
}
