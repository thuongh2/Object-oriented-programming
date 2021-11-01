using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI6
{
    class Giaodich
    {
        private string maGiaoDich;
        private string ngayGiaoDich;
        private double donGia;
        private int soLuong;

        //public Giaodich (string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong)
        //{
        //    this.maGiaoDich = maGiaoDich;
        //    this.ngayGiaoDich = ngayGiaoDich;
        //    this.donGia = donGia;
        //    this.soLuong = soLuong;
        //}

        public string MaGiaoDich { get => maGiaoDich; }
        public string NgayGiaoDich { get => ngayGiaoDich; }
        public double DonGia { get => donGia; }
        public int SoLuong { get => soLuong; }

        public virtual void Input()
        {
            Console.Write("Mã giao dịch: ");
            maGiaoDich = Console.ReadLine();

            Console.Write("Ngày giao dịch (ngày, tháng, năm): ");
            ngayGiaoDich = Console.ReadLine();

            Console.Write("Đơn giá (VND): ");
            donGia = double.Parse(Console.ReadLine());

            Console.Write("Số lượng: ");
            soLuong = int.Parse(Console.ReadLine());
        }

        public virtual void ShowInfo()
        {
            Console.Write("Mã giao dịch: {0}. Ngày giao dịch: {1}. Đơn giá: {2} VND. Số lượng: {3}", MaGiaoDich, NgayGiaoDich, DonGia, SoLuong);
        }
    }
}
