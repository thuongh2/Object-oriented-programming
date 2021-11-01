using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Library
{
    class LibraryManagement
    {

        static void Main ()
        {
            
            const byte SoSach = 2;
            List<SachGiaoKhoa> sachGiaoKhoa = new List<SachGiaoKhoa>(SoSach);
            Console.WriteLine("===== Nhap thong tin sach giao khoa ==========");
            for (byte i = 0; i < SoSach; i++)
            {
                SachGiaoKhoa sgk = new SachGiaoKhoa();
                sgk.Input();
                float x = sgk.ThanhTien;
                sachGiaoKhoa.Add(sgk);
            }
            Console.Write("Tong tien: ");
            float sum = 0;
            for (byte i =0; i< SoSach; i++)
            {
                sum += sachGiaoKhoa[i].ThanhTien;
            }
            Console.WriteLine(sum);
            Console.WriteLine("Trung binh cong cua sach giáo khoa: ", sum / SoSach);


            Console.WriteLine("======= Xuat thong tin sach giao khoa ========");

            for (byte i = 0; i < SoSach; i++)
                sachGiaoKhoa[i].Output();

        }
    }

}
