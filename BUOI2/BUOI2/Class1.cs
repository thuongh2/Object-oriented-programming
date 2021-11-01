using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class Class1
    {
        static void Main()
        {
            short month;

            Console.Write("Nhap thang : ");
            month = Convert.ToInt16(Console.ReadLine());

            switch (month)
            {
                case 2:
                    short year;

                    Console.Write("Nhap nam ");
                    year = Convert.ToInt16(Console.ReadLine());

                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        Console.WriteLine("Thang co 29 ngay");
                    else
                        Console.WriteLine("Thang co 28 ngay");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang co 30 ngay");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                default:
                    Console.WriteLine("Thang co 31 ngay");
                    break;

            }

        }

    }
}
