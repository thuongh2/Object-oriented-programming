using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI9
{
    class HoaDon
    {
        private string maHoaDon;
        private short day, month, year;
        private string tenKhachHang;
        private short maPhong;
        private double donGia;

        public double DonGia
        {
            get => donGia;
        }

        public short Month { get => month; }
        public short Year { get => year; }

        public virtual void Input ()
        {
            Console.Write("Nhap ma giao dich: ");
            maHoaDon = Console.ReadLine();
            Console.Write("Nhap ten: ");
            tenKhachHang = Console.ReadLine();
            Console.Write("Nhap ngay thang nam: ");
            day = Convert.ToInt16(Console.ReadLine());
            month = Convert.ToInt16(Console.ReadLine());
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
        }

        public virtual void ShowInfo()
        {
            Console.Write("Mã giao dịch: {0}. Ho va Ten: {1} Ngày giao dịch: {2}/{3}/{4}. Đơn giá: {5} VND.",
                maHoaDon, tenKhachHang, day, month, year, DonGia);
        }

    }
}
