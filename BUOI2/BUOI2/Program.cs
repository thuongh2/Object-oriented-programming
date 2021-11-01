using System;

namespace BUOI2
{
    class Program
    {
        static void Main()
        {
            float toan, ly, hoa, dtb;

            Console.Write("Nhap diem toan: ");
            toan = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            ly = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            hoa = Convert.ToSingle(Console.ReadLine());

            dtb = (toan + ly + hoa) / 3;

            Console.WriteLine("Diem trung binh cong la: {0:0.00}", dtb);

            if (dtb < 5)
                Console.WriteLine("Yeu");
            else if (dtb < 6.5)
                Console.WriteLine("Trung binh");
            else if (dtb < 8)
                Console.WriteLine("Kha");
            else if (dtb < 9)
                Console.WriteLine("Gioi");
            else
                Console.WriteLine("Xuat sac");
        }
    }
}
