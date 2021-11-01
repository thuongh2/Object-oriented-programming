using System;

namespace BAI1
{
    class Bai13
    {
        static void Main ()
        {
            byte N;
            Console.Write("Nhap so N: ");
            N = Convert.ToByte(Console.ReadLine());

            for (byte i = 1; i <= N; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (byte i = N; i > 0; i--)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (byte i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            for (byte i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }

        }
    }
}
