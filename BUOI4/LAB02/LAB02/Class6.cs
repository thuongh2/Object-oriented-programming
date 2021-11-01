using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            string name;
            Console.Write("Hay nhap ten cua ban: ");
            name = Convert.ToString(Console.ReadLine());

            string[] nameDetail = name.Split(" ");

            byte len = (byte)nameDetail.Length;

            Console.WriteLine("{0}.{1}{2}@r2s.edu.vn", nameDetail[len - 1], nameDetail[0], nameDetail[1]);

            string oneFirstName = nameDetail[1];
            string oneMiddelName = nameDetail[2];

            Console.WriteLine("{0}.{1}{2}@r2s.edu.vn", nameDetail[len - 1], oneFirstName[0], oneMiddelName[0]);
        }
    }
}
