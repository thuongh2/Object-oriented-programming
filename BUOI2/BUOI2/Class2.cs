using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class Class2
    {
        static void Main()
        {
            int number_a;
            int number_b;
            float result;

            Console.Write("Nhap vao so a: ");
            number_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao so b: ");
            number_b = Convert.ToInt32(Console.ReadLine());

            if (number_b == 0)
                Console.WriteLine("Khong the thuc hien phep chia");
            else
            {
                result = (float)(number_a / (float)number_b);
                Console.WriteLine("Ket qua a chia b {0}", result);
            }
        }
    }
}
