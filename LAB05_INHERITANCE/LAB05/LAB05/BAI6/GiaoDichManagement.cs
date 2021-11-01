using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI6
{
    class GiaoDichManagement
    {
        static void menuGiaoDichVang()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<GiaoDichVang> giaoDichVangs = new List<GiaoDichVang>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                GiaoDichVang gaoDichVang = new GiaoDichVang();
                gaoDichVang.Input();
                giaoDichVangs.Add(gaoDichVang);
            }

            double sum = 0;
            for (byte i =0; i< soGiaoDich; i++)
            {
                sum += giaoDichVangs[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                giaoDichVangs[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich co don gia hon 1 ty: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (giaoDichVangs[i].DonGia > 1000000000)
                    giaoDichVangs[i].ShowInfo();
            }
        }

        static void menuGiaoDichTienTe()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<GiaoDichTienTe> giaoDichVangs = new List<GiaoDichTienTe>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                GiaoDichTienTe gaoDichVang = new GiaoDichTienTe();
                gaoDichVang.Input();
                giaoDichVangs.Add(gaoDichVang);
            }

            double sum = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                sum += giaoDichVangs[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                giaoDichVangs[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich co don gia hon 1 ty: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (giaoDichVangs[i].DonGia > 1000000000)
                    giaoDichVangs[i].ShowInfo();
            }
        }

        static void menu ()
        {
            while (true)
            {
                byte select;
                Console.WriteLine("1. Giao Dich Vang");
                Console.WriteLine("2. Giao Dich Tien Te");
                Console.Write("Nhap lua chon: ");
                select = byte.Parse(Console.ReadLine());
                if (select == 1)
                    menuGiaoDichVang();
                else if (select == 2)
                    menuGiaoDichTienTe();
                else
                    break;
            }
        }
        static void Main ()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            menu();

        }
    }
}
