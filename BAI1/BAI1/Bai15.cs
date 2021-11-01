using System;
using System.Text;

namespace BAI1
{
    class Bai15
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char character = 'A';
            const short row = 11;
            const short col = 12;
            int i, j;

            Console.WriteLine("\t\t\tSƠ HỒ CHỖ NGỒI");

            for (i = 0; i < 73; i++)
                Console.Write("=");
            Console.WriteLine();

            Console.WriteLine("\t\t\tMÀN HÌNH");
            for (i = 0; i < 73; i++)
                Console.Write("=");
            Console.WriteLine();

            for (i = 0; i < row; i++)
            {
                Console.Write("{0}  ", Convert.ToChar(character + i));
                for (j = 1; j <= col; j++)
                {
                    if (j < 10)
                        Console.Write("[0{0}]  ", j);
                    else
                        Console.Write("[{0}]  ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
