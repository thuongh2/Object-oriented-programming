using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai11
    { 
        static void Main ()
        {
            short data;
            ushort[] price = { 60, 55, 45, 30 };
            ushort[] Mb = { 500, 350, 250, 200 };

            Console.Write("Nhap dung luong data: ");
            data = (short)Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Luong MB\tDon gia \tThanh tien");
            Console.WriteLine("==========================================");

            int d = data;
            int sumPrice = 0;
            byte i = 0;

            while (data > 0 && i<4)
            {
                if (data - Mb[i] <= 0)
                {
                    sumPrice += data * price[i];
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", data, price[i], data * price[i]);
                }
                else
                {
                    sumPrice += Mb[i] * price[i];
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", Mb[i], price[i], Mb[i]*price[i]);
                }
                data = (short)(data - Mb[i]);
                i++;
            }

            if (i > 3)
            {
                sumPrice += data * 15;
                Console.WriteLine("{0}\t\t{1}\t\t{2}", data, 15, data * 15);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine("{0}\t\t\t\t{1}", d, sumPrice);
        }
    }
}
