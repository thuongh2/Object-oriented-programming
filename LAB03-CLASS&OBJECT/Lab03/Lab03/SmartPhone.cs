using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class SmartPhone
    {
        public string phoneName;
        public string brandPhone;
        public short RAM;
        public int price;

        public SmartPhone ()
        {
            phoneName = "NULL";
            brandPhone = "Unknow";
            RAM = 0;
            price = 0;
        }

        public SmartPhone(string phoneName, string brandPhone, short RAM, int price)
        {
            this.phoneName = phoneName;
            this.brandPhone = brandPhone;
            this.RAM = RAM;
            this.price = price;
        }

        public void InputPhone()
        {
            Console.Write("Nhap ten dien thoai: ");
            phoneName = Console.ReadLine();
            Console.Write("Nhap hang san xuat: ");
            brandPhone = Console.ReadLine();
            Console.Write("Nhap bo nho RAM: ");
            RAM = (short)(ushort)Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap gia tien: ");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowInfo()
        {
            Console.WriteLine("Ten dien thoai: {0}, Hang san xuat: {1}, Bo nho Ram: {2}, Gia tien: {3}", phoneName, brandPhone, RAM, price);
        }

        public void ComparePhone (SmartPhone s2)
        {
            if (price > s2.price)
                Console.WriteLine("Dien thoai {0} mac hon dien thoai {1}", phoneName, s2.phoneName);
            else if (price == s2.price)
                Console.WriteLine("Dien thoai {0} ngang gia dien thoai {1}", phoneName, s2.phoneName);
            else
                Console.WriteLine("Dien thoai {0} re hon dien thoai {1}", phoneName, s2.phoneName);

        }
    }
}
