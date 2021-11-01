using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI6
{
    class GiaoDichTienTe: Giaodich
    {
        private string loaiTienTe;
        private double tiGia;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                thanhTien = SoLuong * DonGia * tiGia;
                return thanhTien;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai vang: ");
            loaiTienTe = Console.ReadLine();
            Console.Write("Nhap ti gia: ");
            tiGia = double.Parse(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Loai Vang: {0},Ti Gia {1}, Thanh Tien: {2}", loaiTienTe,tiGia, ThanhTien);
        }
    }
}
