using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Library
{
    class Library
    {
        private int id;
        private int day, month, year;
        private int price;
        private int count;
        private string nameXB;

        public Library()
        {

        }

        public Library(int id, int day, int month,int count, int year, int price, string nameXB)
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.count = count;
            this.year = year;
            this.price = price;
            this.nameXB = nameXB;
        }

        public virtual void Input ()
        {
            Console.Write("Nhap id: " );
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap day: " );
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap month: " );
            month = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Nhap year: " );
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia: " );
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so luong: " );
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap nxb: " );
            nameXB = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("{0} - {1} - {2} - {3} - {4} - {5} - {6}", id, day, month, year, price, count, nameXB);
        }

        public int Count
        {
            get => count;
        }

        public int Price
        {
            get => price;
        }

    }
}
