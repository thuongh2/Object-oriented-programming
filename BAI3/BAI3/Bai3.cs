using System;

namespace BAI3
{
    class Bai3
    {
        static void Main()
        {
            byte number_fibo;

            Console.Write("Nhap so N: ");
            number_fibo = Convert.ToByte(Console.ReadLine());

            byte fibo_1 = 1;
            byte fibo_0 = 0;
            byte fibo_n = 0;

            for (byte i = 0; i < number_fibo; i++)
            {
                fibo_n = (byte)(fibo_1 + fibo_0);
                fibo_1 = fibo_0;
                fibo_0 = fibo_n;

                Console.Write("{0} ", fibo_n);
            }
        }
    }
}
