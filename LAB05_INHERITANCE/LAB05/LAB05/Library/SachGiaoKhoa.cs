using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Library
{
    class SachGiaoKhoa : Library
    {
        private byte tinhTrang;
        private float thanhTien;
        public SachGiaoKhoa()
        {

        }

        public SachGiaoKhoa(int id, int day, int month, int count, int year, int price, string nameXB, byte tinhTrang) : base(id, day, month,count,  year, price, nameXB)
        {
            this.tinhTrang = tinhTrang;
        }

        public float ThanhTien
        {
            get 
            {
                if (tinhTrang == 1)
                    thanhTien = Count * Price;
                else
                    thanhTien = (float)(Count * Price * 0.5);
                return thanhTien;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap tinh trang: ");
            tinhTrang = Convert.ToByte(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("- {0} - {1}", tinhTrang, thanhTien);
        }
    }
}
