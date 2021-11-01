using System;

namespace BAI3
{
    class Bai4
    {
        static void Main()
        {
            byte n;
            byte multiple;

            Console.Write("Nhap so n: ");
            n = Convert.ToByte(Console.ReadLine());

            for (byte i = 1; i <= 9; i++)
            {
                multiple = (byte)(n * i);
                Console.WriteLine("{0} * {1} = {2}", n, i, multiple);
            }
        }
    }
}
