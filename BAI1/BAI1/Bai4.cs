using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai4
    {
        static void Main(string[] args)
        {
            short total;
            short absent;

            Console.Write("Tong so: ");
            total = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("HS vang: ");
            absent = Convert.ToInt16(Console.ReadLine());

            float percent = (absent / (float)total) * 100;

            Console.WriteLine("Ty le chuyen can {0}%, Ty le hoc sinh van {1}%", 100 - percent, percent);

        }
    }
}
