using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class Class5
    {
        static void Main()
        {
            int salary;
            char rank;

            int salaryFinish = 0;

            Console.Write("Nhap luong: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap thu hang: ");
            rank = Convert.ToChar(Console.ReadLine());

            switch (rank)
            {
                case 'A':
                    salaryFinish = salary + 300;
                    break;
                case 'B':
                    salaryFinish = salary + 200;
                    break;
                case 'C':
                    salaryFinish = salary + 100;
                    break;
                default:
                    Console.WriteLine("Nhap khong dung");
                    break;

            }

            Console.WriteLine("Luong thuc lanh cua nhan vien: {0}", salaryFinish);


        }
    }
}
