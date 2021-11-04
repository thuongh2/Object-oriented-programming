using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI9
{
    class HoaDonTheoNgay:HoaDon
    {
        private float soNgayThue;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                if (soNgayThue <= 7)
                    return thanhTien = soNgayThue * DonGia;
                else
                    return thanhTien = soNgayThue * DonGia * 0.8;//Neu lon >7 ngay thi giam 20%
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so ngay thue: ");
            soNgayThue = Convert.ToSingle(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("So gio thue {0}, Thanh Tien {1}", soNgayThue, ThanhTien);
        }
    }
}
