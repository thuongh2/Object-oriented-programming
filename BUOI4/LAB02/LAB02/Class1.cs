using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class1
    {
        static void Main()
        {
            byte n;
            Console.Write("Nhap so phan tu cua mang: ");
            n = Convert.ToByte(Console.ReadLine());

            int[] arr = new int[n];

            for (byte i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Nhap phan tu can xoa ");
            int x = Convert.ToInt32(Console.ReadLine());

            byte count = 0;
            for (byte i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                    for (byte j = i; j < n - 1; j++)
                        arr[j] = arr[j + 1];
                    n--;
                    i--;
                }
            }

            if (count == 0)
                Console.WriteLine("-1");
            else
                for (byte i = 0; i < n; i++)
                    Console.Write("{0} ", arr[i]);
        }
    }
}
