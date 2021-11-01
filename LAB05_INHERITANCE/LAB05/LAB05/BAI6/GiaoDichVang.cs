using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI6
{
    class GiaoDichVang : Giaodich
    {
        private string loaiVang;
        private double thanhTien;

        //public GiaoDichVang(string maGiaoDich, string ngayGiaoDich, string donGia, int soLuong, string loaiVang)
        //    : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        //{
        //    this.loaiVang = loaiVang;
        //}

        public double ThanhTien
        {
            get
            {
                thanhTien = SoLuong * DonGia;
                return thanhTien;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai vang: ");
            loaiVang = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Loai Vang: {0}, Thanh Tien: {1}", loaiVang, ThanhTien);
        }
    }
}
