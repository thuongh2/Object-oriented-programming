using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class Class3
    {
        static void Main ()
        {
            int number_a;
            int number_b;
            int number_c;

            Console.Write("Nhap so a: ");
            number_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so b: ");
            number_b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so c: ");
            number_c = Convert.ToInt32(Console.ReadLine());

            int max = number_a;

            if (number_b > max)
                max = number_b;
            if (number_c > max)
                max = number_c;

            Console.WriteLine("So lon nhat trong ba so la {0} ", max);

        }
    }
}
