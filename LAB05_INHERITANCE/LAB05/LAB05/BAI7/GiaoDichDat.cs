using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI7
{
    class GiaoDichDat: GiaoDich
    {
        private char loaiDat;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                if (loaiDat == 'B' || loaiDat == 'C')
                    thanhTien = DienTich * DonGia;
                else
                    thanhTien = DienTich * DonGia * 1.5;
                return thanhTien;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai Dat (A, B, C): ");
            loaiDat = char.Parse(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Loai Dat {0}, Thanh Tien {1}", loaiDat, ThanhTien);
        }
    }
}
