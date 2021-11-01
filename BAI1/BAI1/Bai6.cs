using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai6
    {
        static void Main ()
        {
            short year;
            const short yearCurrent = 2021;

            Console.Write("Nhap nam sinh: ");
            year = Convert.ToInt16(Console.ReadLine());

            short age = (short)(yearCurrent - year);

            if (age >= 18)
                Console.WriteLine("Ban da du tuoi lai xe");
            else
                Console.WriteLine("Ban chua du tuoi lai xe");

        }
    }
}
