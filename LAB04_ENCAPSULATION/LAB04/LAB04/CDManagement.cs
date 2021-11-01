using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class CDManagement
    {
        static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Them sinh vien ");
            Console.WriteLine("2. Sap xep CD theo gia ");
            Console.WriteLine("3. Sap xep CD theo tua de ");
            Console.WriteLine("4. Xuat sinh vien ");
            Console.WriteLine();

        }
        static void Main()
        {
            ListCD a = new ListCD();
            int x = a.CountCD;
            int y = a.PriceCD;

            byte select;
            while (true)
            {
                menu();
                Console.Write("Nhap lua chon ");

                select = Convert.ToByte(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        CD them = new CD();
                        Console.WriteLine("Nhap STT");
                        them.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nhap tieu de");
                        them.Title = Console.ReadLine();
                        Console.WriteLine("Nhap Ten bai hat");
                        them.Singer = Console.ReadLine();
                        Console.WriteLine("Nhap so luong bai hat");
                        them.NumberSong = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Nhap gia");
                        them.Price = Convert.ToInt32(Console.ReadLine());

                        a.ThemCD(them);
                        break;
                    case 2:
                        a.SapXepTheoTuaDe();
                        a.XuatDS();
                        break;
                    case 3:
                        a.SepTheoGiaTien();
                        a.XuatDS();
                        break;
                    case 4:
                        a.XuatDS();
                        break;
                    default:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                }
            }
        }
    }
}
