using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class3
    {
        static byte soLanXuatHien(int[] arr, int x)
        {
            byte count = 0;
            foreach (int item in arr)
            {
                if (item == x)
                    count++;
            }
            return count;
        }

        static void InPhanTuTrungLap(int[] arr)
        {
            int c = 1;
            for (int i= 1; i< arr.Length;i++)
            {
                if (arr[i] == arr[i - 1])
                    ++c;
                else
                {
                    if (c>= 3)
                        Console.WriteLine("Phan tu {0} xuat hien {1}", arr[i-1], c);
                    c = 1;
                }
            }
            if (c>=3)
                Console.WriteLine("Phan tu {0} xuat hien {1}", arr[arr.Length-1], c);
        }

    

        static void Main()
        {
            const byte size = 20;
            int[] arr = new int[size];
            Random Rand = new Random();

            for (byte i = 0; i < size; i++)
            {
                arr[i] = Rand.Next(1, 10);
            }

            int x;
            Console.Write("Nhap so X: ");
            x = Convert.ToInt32(Console.ReadLine());

            byte count = soLanXuatHien(arr, x);

            Console.WriteLine("So lan xuat hien so {0} tron arr: {1}", x, count);

            Array.Sort(arr);

            InPhanTuTrungLap(arr);

            foreach (int item in arr)
                Console.Write("{0} ", item);
        }

    }
}
