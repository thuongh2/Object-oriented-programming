using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Library
{
    class SachThamKhao: Library
    {
        private float thue;
        private float thanhTien;

        public SachThamKhao()
        {

        }

        public SachThamKhao(int id, int day, int month,int count, int year, int price, string nameXB, float thue) : base(id, day, month,count, year, price, nameXB)
        {
            this.thue = thue;
        }

        public float ThanhTien
        {
            get
            {
                thanhTien = Count * Price + thue;
                return thanhTien;
            }

        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap thue: ");
            thue = Convert.ToSingle(Console.ReadLine());
        }
    }
}
