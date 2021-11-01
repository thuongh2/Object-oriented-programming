using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai14
    {
        static void Main ()
        {
            byte N;
            Console.Write("Nhap vao so nguyen N: ");
            N = Convert.ToByte(Console.ReadLine());

            int sum =1;
            int temp = 1;
            Console.Write("Yeu cau 1: ");
            for (byte i= 1; i<= N; i++)
            {
                sum *= i;
            }
            Console.WriteLine("Giai thua cua so nguyen N la: {0}", sum);

            sum = 0;
            Console.Write("Yeu cau 2: ");
            for (byte i = 1; i <= N; i++)
            {
                temp *= i;
                sum += temp;
            }
            Console.WriteLine("Giai thua cua N so nguyen la: {0}", sum);

            byte count = 0;
            Console.Write("Yeu cau 3: ");
            for (byte i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                    count++;
            }
            Console.WriteLine("So luong so chia het cho 3 va 7: {0}", count);
        }
    }
}
