using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            float weight;
            float height;

            Console.Write("Nhap can nang: ");
            weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap chieu cao: ");
            height = Convert.ToSingle(Console.ReadLine());

            float BMI = weight / (height * height);

            if (BMI < 18.5)
                Console.WriteLine("Gầy");
            else if (BMI <= 24.9)
                Console.WriteLine("Cân đối");
            else if (BMI <= 29.9)
                Console.WriteLine("Thừa cân");
            else if (BMI <= 34.9)
                Console.WriteLine("Béo phì cấp độ 1");
            else if (BMI <= 39.9)
                Console.WriteLine("Béo phì cấp độ 2");
            else
                Console.WriteLine("Béo phì cấp độ 3");

        }
    }
}
