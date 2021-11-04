using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI7
{
    class GiaoDich
    {
        private string maGiaoDich;
        private short day, mounth, year;
        private double donGia;
        private double dienTich;

        public short Day { get => day; }
        public short Mounth { get => mounth; }
        public short Year { get => year; }
        public double DonGia { get => donGia; }
        public double DienTich { get => dienTich; }

        public virtual void Input ()
        {
            Console.Write("Nhap ma giao dich: ");
            maGiaoDich = Console.ReadLine();
            Console.Write("Nhap ngay thang nam: ");
            day = Convert.ToInt16(Console.ReadLine());
            mounth = Convert.ToInt16(Console.ReadLine());
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            donGia = double.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich: ");
            dienTich = double.Parse(Console.ReadLine());
        }

        public virtual void ShowInfo()
        {
            Console.Write("Ma Giao Dich {0}, Ngay Giao Dich: {1}/{2}/{3}, Don gia {4}, Dien tich {5}", maGiaoDich, day, mounth, year, donGia, dienTich);
        }
    }
}
