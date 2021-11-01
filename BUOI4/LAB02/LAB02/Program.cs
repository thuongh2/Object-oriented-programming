using System;

namespace LAB02
{
    class Program
    {
        static void Main()
        {
            short[] arr = { 10, 25, -4, 32, 63, 81, 19, -24, 13, 18, 45, 12, 72, 42, -6 };

            Console.WriteLine("Vi tri va gia tri cac phan tu la so le: ");
            for (byte i=0; i<arr.Length;i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write("{0}: {1}, ",i, arr[i]);
            }
            Console.WriteLine(Environment.NewLine);

            byte count = 0;
            for (byte i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] % 6 == 0)
                    count++;
            }
            Console.WriteLine("So cac phan tu chia het cho 2 va chia het cho 6: {0}", count);
            Console.WriteLine();

            short sum = 0;
            for (byte i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    sum += arr[i];
            }
            Console.WriteLine("Tong gia tri cac phan tu co tri so chan: {0}", sum);
            Console.WriteLine();

            Console.WriteLine("Thay the cac gia tri am bang 0: ");
            for (byte i=0; i< arr.Length;i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;
            }

            foreach (short item in arr)
                Console.Write("{0} ", item);
            Console.WriteLine();

        }
    }
}
