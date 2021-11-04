using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI8
{
    class KhachHangNuocNgoai: HoaDon
    {
        private string quocTich;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                return thanhTien = SoLuong * DonGia;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap quoc tich: ");
            quocTich = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Quoc Tich: {0}, Thanh Tien {1}", quocTich, ThanhTien);
        }

    }
}
