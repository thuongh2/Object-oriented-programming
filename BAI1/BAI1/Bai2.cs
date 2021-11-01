using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class bai2
    {
        static void Main(string[] args)
        {
            int salary;
            float salaryCurrent;
            const float percent = 0.85F;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Lương chính thức: ");
            salary = Convert.ToInt32(Console.ReadLine());

            salaryCurrent = salary * percent;

            Console.WriteLine("Lương thử việc: {0}", salaryCurrent);

        }

    }
}
