using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.BAI9
{
    class HoaDonTheoGio: HoaDon
    {
        private float soGioThue;
        private double thanhTien;

        public double ThanhTien
        {
            get
            {
                if (soGioThue < 24)
                    return thanhTien = soGioThue * DonGia;
                else if (soGioThue < 30)
                    return thanhTien = 24 * DonGia;
                else
                {
                    Console.WriteLine("Khong the dung hoa don theo gio");
                    return -1;
                }
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so gio: ");
            soGioThue = Convert.ToSingle(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("So gio thue {0}, Thanh Tien {1}", soGioThue, ThanhTien);
        }
    }
}
