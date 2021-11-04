using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI9
{
    class HoaDonManagement
    {
        static void menuHoaDonTheoGio()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<HoaDonTheoGio> HoaDonTheoGios = new List<HoaDonTheoGio>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                HoaDonTheoGio HoaDonTheoGio = new HoaDonTheoGio();
                HoaDonTheoGio.Input();
                HoaDonTheoGios.Add(HoaDonTheoGio);
            }

            for (byte i = 0; i < soGiaoDich; i++)
            {
                HoaDonTheoGios[i].ShowInfo();
            }
            //Tong hoa don trong thanh 9/2013
            
            double sum = 0;
            short soGiaoDichTrongNgay =0 ;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (HoaDonTheoGios[i].Month == 9 && HoaDonTheoGios[i].Year == 2013)
                {
                    sum += HoaDonTheoGios[i].ThanhTien;
                    soGiaoDichTrongNgay++;
                }
            }

            Console.WriteLine("Trung binh tien trong thang 9/2013: ", sum / soGiaoDichTrongNgay);
        }

        static void menuHoaDonTheoNgay()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<HoaDonTheoNgay> HoaDonTheoNgays = new List<HoaDonTheoNgay>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                HoaDonTheoNgay HoaDonTheoNgay = new HoaDonTheoNgay();
                HoaDonTheoNgay.Input();
                HoaDonTheoNgays.Add(HoaDonTheoNgay);
            }

            for (byte i = 0; i < soGiaoDich; i++)
            {
                HoaDonTheoNgays[i].ShowInfo();
            }
            double sum = 0;
            short soGiaoDichTrongNgay = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (HoaDonTheoNgays[i].Month == 9 && HoaDonTheoNgays[i].Year == 2013)
                {
                    sum += HoaDonTheoNgays[i].ThanhTien;
                    soGiaoDichTrongNgay++;
                }
            }

            Console.WriteLine("Trung binh tien trong thang 9/2013: ", sum / soGiaoDichTrongNgay);
        }

        static void menu()
        {
            while (true)
            {
                byte select;
                Console.WriteLine("1. Khach Hang Viet Nam");
                Console.WriteLine("2. Khach Hang Nuoc Ngoai");
                Console.Write("Nhap lua chon: ");
                select = byte.Parse(Console.ReadLine());
                if (select == 1)
                    menuHoaDonTheoGio();
                else if (select == 2)
                    menuHoaDonTheoNgay();
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
