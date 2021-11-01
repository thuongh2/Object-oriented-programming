using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            string name;
            Console.Write("Hay nhap ten cua ban: ");
            name = Convert.ToString(Console.ReadLine());

            byte startIndex;
            byte length;

            Console.Write("Nhap vi tri bat dau cat: ");
            startIndex = Convert.ToByte(Console.ReadLine());

            Console.Write("Nhap so luong ki tu muon cat: ");
            length = Convert.ToByte(Console.ReadLine());

            string namesplit = name.Substring(startIndex, length);

            Console.WriteLine("Ket qua sau khi cat: " + namesplit);
        }
    }
}
