using System;

namespace BAI3
{
    class Bai2
    {
        static void Main()
        {
            byte number_n1;
            byte number_n2;
            ushort sum = 0;

            Console.Write("Nhap so n1: ");
            number_n1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Nhap so n2: ");
            number_n2 = Convert.ToByte(Console.ReadLine());

            for (byte i = number_n1; i <= number_n2; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine("Tong cua cac so le tu {0} den {1} la: {2}", number_n1, number_n2, sum);

        }

    }
}
