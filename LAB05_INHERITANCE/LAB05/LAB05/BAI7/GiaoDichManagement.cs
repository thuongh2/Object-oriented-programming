using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI7
{
    class GiaoDichManagement
    {
        static void menuGiaoDat()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<GiaoDichDat> giaoDichDats = new List<GiaoDichDat>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                GiaoDichDat gaoDichDat = new GiaoDichDat();
                gaoDichDat.Input();
                giaoDichDats.Add(gaoDichDat);
            }

            double sum = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                sum += giaoDichDats[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                giaoDichDats[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich cua thang 9 2013: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (giaoDichDats[i].Mounth == 9 && giaoDichDats[i].Year == 2013)
                    giaoDichDats[i].ShowInfo();
            }
        }

        static void menuGiaoDichNha()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<GiaoDichNha> giaoDichNhas = new List<GiaoDichNha>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                GiaoDichNha gaoDichNha = new GiaoDichNha();
                gaoDichNha.Input();
                giaoDichNhas.Add(gaoDichNha);
            }

            double sum = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                sum += giaoDichNhas[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                giaoDichNhas[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich co don gia hon 1 ty: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (giaoDichNhas[i].Mounth == 9 && giaoDichNhas[i].Year == 2013)
                    giaoDichNhas[i].ShowInfo();
            }
        }

        static void menu()
        {
            while (true)
            {
                byte select;
                Console.WriteLine("1. Giao Dich Dat");
                Console.WriteLine("2. Giao Dich Nha");
                Console.Write("Nhap lua chon: ");
                select = byte.Parse(Console.ReadLine());
                if (select == 1)
                    menuGiaoDat();
                else if (select == 2)
                    menuGiaoDichNha();
                else
                    break;
            }
        }

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            menu();
        }
    }
}
