using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class TuGiacManagement
    {
        static void Main()
        {
            Tugiac t1 = new Tugiac();
            Tugiac t2 = new Tugiac(5);
            Tugiac t3 = new Tugiac(6, 3);

            Console.WriteLine("Hinh {0}, co chu vi la: {1}, co dien tich la: {2}", t1.PhanLoaiTG(), t1.TinhChuVi(), t1.TinhDienTich());
            t1.VeTuGiac();
            Console.WriteLine();

            Console.WriteLine("Hinh {0}, co chu vi la: {1}, co dien tich la: {2}", t2.PhanLoaiTG(), t2.TinhChuVi(), t2.TinhDienTich());
            t2.VeTuGiac();
            Console.WriteLine();

            Console.WriteLine("Hinh {0}, co chu vi la: {1}, co dien tich la: {2}", t3.PhanLoaiTG(), t3.TinhChuVi(), t3.TinhDienTich());
            t3.VeTuGiac();
            Console.WriteLine();

        }
    }
}
