using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI8
{
    class HoaDon
    {
        private string maGiaoDich;
        private string hoTen;
        private short day, month, year;
        private double donGia;
        private int soLuong;

        public short Month { get => month; }
        public short Year { get => year; }
        public double DonGia { get => donGia; }
        public int SoLuong { get => soLuong; }

        public virtual void Input()
        {
            Console.Write("Nhap ma giao dich: ");
            maGiaoDich = Console.ReadLine();
            Console.Write("Nhap ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ngay thang nam: ");
            day = Convert.ToInt16(Console.ReadLine());
            month = Convert.ToInt16(Console.ReadLine());
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void ShowInfo()
        {
            Console.Write("Mã giao dịch: {0}. Ho va Ten: {1} Ngày giao dịch: {2}/{3}/{4}. Đơn giá: {5} VND. Số lượng: {6}",
                maGiaoDich, hoTen, day, month, year, DonGia, SoLuong);
        }

    }
}
