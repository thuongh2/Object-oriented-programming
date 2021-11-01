using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai10
    {
        static void Main()
        {
            float score1;
            float score2;
            float score3;

            Console.Write("Nhap diem nam 1: ");
            score1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap diem nam 1: ");
            score2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap diem nam 1: ");
            score3 = Convert.ToSingle(Console.ReadLine());

            float avg = (score1 + score2 + score3) / 3;

            Console.WriteLine("Diem nam 1 la {0}, Diem nam 2 la {1}, Diem nam 3 la {2}", score1, score2, score3);

            if (score1 >= 8.5 && score2 >= 8.5 && score3 >= 8.5)
                Console.WriteLine("Diem trung binh la {0}, Ban duoc tang mot may tinh laptop", avg);

            else if (score1 >= 8.5 && score2 >= 8.5 || score2 >= 8.5 && score3 >= 8.5 || score1 >= 8.5 && score3 >= 8.5)
                Console.WriteLine("Diem trung binh la {0}, Ban duoc tang mot xe dap leo nui", avg);

            else if (score1 >= 6.5 && score2 >= 6.5 && score3 >= 6.5)
                Console.WriteLine("Diem trung binh la {0}, Ban duoc tang mot balo", avg);

            else
                Console.WriteLine("Diem trung binh la {0}, Ban khong nhan duoc gi, Hay hoc cham chi hon", avg);

        }

    }
}
