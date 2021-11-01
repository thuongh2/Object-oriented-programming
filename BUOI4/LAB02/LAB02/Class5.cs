using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class5
    {
        static void Main ()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            string name;
            Console.Write("Hay nhap ten cua ban: ");
            name = Convert.ToString(Console.ReadLine());

            string[] nameDetail = name.Split(" ");

            byte len = (byte)nameDetail.Length;

            Console.WriteLine("Xin chào {0}, tên của bạn có {1} từ.", nameDetail[len - 1], len);
        }
    }
}
