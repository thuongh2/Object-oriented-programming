using System;

namespace BAI1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            string name;
            short year;
            const short yearCurrent = 2021;
            const short yearFuture = 2025;

            Console.Write("Nhap ten cua ban: ");
            name = Console.ReadLine();

            Console.Write("Nhap nam sinh cua ban: ");
            year = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Hi {0}, tuoi hien tai cua ban la {1}, tuoi o nam 2025 la {2}", name, yearCurrent - year, yearFuture - year);

        }
    }
}
