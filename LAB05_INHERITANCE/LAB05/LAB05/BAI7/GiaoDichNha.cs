using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI7
{
    class GiaoDichNha: GiaoDich
    {
        private string loaiNha;
        private string diaChi;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                if (loaiNha == "cao cap")
                    thanhTien = DienTich * DonGia;
                else
                    thanhTien = DienTich * DonGia * 0.9;
                return thanhTien;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai Nha (Cao cap, Thuong): ");
            loaiNha = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Loai Nha {0},Dia Chi {1}, Thanh Tien {2}", loaiNha,diaChi, ThanhTien);
        }
    }
}
