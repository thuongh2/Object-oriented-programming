using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class4
    {
        static byte KiemTra (int [] arr, int number, byte n)
        {
            for (byte i=0; i<n; i++)
                if (arr[i] == number)
                    return 1;
            return 0;
        }

        static void XoaPhanTu (int [] arr, byte pos,ref byte n)
        {
            for (byte i = pos; i < n-1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
        }

        static void HienThi (int [] arr, byte n)
        {
            for (byte i = 0; i < n; i++)
                Console.Write("{0} ", arr[i]);
        }

        static void Main ()
        {
            const byte size = 20;
            int[] arr = new int[size];
            Random Rand = new Random();
            for (byte i = 0; i < size; i++)
            {
                arr[i] = Rand.Next(1, 10);
            }

            Array.Sort(arr);

            int number;
            Console.Write("Nhap vao so nguyen: ");
            number = Convert.ToInt32(Console.ReadLine());

            byte n = (byte)arr.Length;

            HienThi(arr, n);

            for (byte i=0; i< n; i++)
            {
                if (KiemTra(arr, number, n) == 1)
                {
                    XoaPhanTu(arr, i, ref n);
                    i--;
                }
            }
            Console.Write("Phan tu da xoa\n");
            HienThi(arr, n);

        }
    }
}
