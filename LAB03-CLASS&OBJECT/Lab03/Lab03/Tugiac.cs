using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Tugiac
    {
        public int a;
        public int b;

        public Tugiac()
        {
            this.a = 0;
            this.b = 0;
        }

        public Tugiac(int a)
        {
            this.a = a;
            this.b = a;
        }

        public Tugiac(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void VeTuGiac ()
        {
            if (a == 0 && b == 0)
                Console.WriteLine("Khong the ve hinh");
            else
            {
                for (int i=0; i< b; i++)
                {
                    for (int j = 0; j < a; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }

        public int TinhChuVi ()
        {
            return ((a + b) * 2);
        }

        public int TinhDienTich ()
        {
            return(a * b);
        }

        public string PhanLoaiTG()
        {
            if (a == 0 && b == 0)
                return "Khong biet";
            else if (a != 0 && b != 0 && a != b)
                return "Chu Nhat";
            return "Hinh Vuong";
        }

    }
}
