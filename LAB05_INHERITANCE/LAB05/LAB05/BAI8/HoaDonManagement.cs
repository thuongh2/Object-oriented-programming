using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI8
{
    class HoaDonManagement
    {
        static void menuKhachHangVietNam()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<KhachHangVietNam> KhachHangVietNams = new List<KhachHangVietNam>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                KhachHangVietNam KhachHangVietNam = new KhachHangVietNam();
                KhachHangVietNam.Input();
                KhachHangVietNams.Add(KhachHangVietNam);
            }

            double sum = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                sum += KhachHangVietNams[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                KhachHangVietNams[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich cua thang 9 2013: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (KhachHangVietNams[i].Month == 9 && KhachHangVietNams[i].Year == 2013)
                    KhachHangVietNams[i].ShowInfo();
            }
        }

        static void menuKhachHangNuocNgoai()
        {
            byte soGiaoDich;
            Console.Write("Nhap so giao dich: ");
            soGiaoDich = byte.Parse(Console.ReadLine());

            List<KhachHangNuocNgoai> KhachHangNuocNgoais = new List<KhachHangNuocNgoai>(soGiaoDich);

            Console.WriteLine("Nhap thong tin giao dich");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                KhachHangNuocNgoai khachHangNuocNgoai= new KhachHangNuocNgoai();
                khachHangNuocNgoai.Input();
                KhachHangNuocNgoais.Add(khachHangNuocNgoai);
            }

            double sum = 0;
            for (byte i = 0; i < soGiaoDich; i++)
            {
                sum += KhachHangNuocNgoais[i].ThanhTien;
            }

            Console.WriteLine("Trung binh thanh tien giao dich: {0}", sum / soGiaoDich);

            for (byte i = 0; i < soGiaoDich; i++)
            {
                KhachHangNuocNgoais[i].ShowInfo();
            }
            //Giao dich co don gia hon 1 ty
            Console.WriteLine("Giao dich co don gia hon 1 ty: ");
            for (byte i = 0; i < soGiaoDich; i++)
            {
                if (KhachHangNuocNgoais[i].Month == 9 && KhachHangNuocNgoais[i].Year == 2013)
                    KhachHangNuocNgoais[i].ShowInfo();
            }
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
                    menuKhachHangVietNam();
                else if (select == 2)
                    menuKhachHangNuocNgoai();
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
