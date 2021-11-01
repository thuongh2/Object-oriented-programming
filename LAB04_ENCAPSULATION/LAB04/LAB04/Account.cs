using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class Account
    {
        private int maPIN;
        private int soDu;
        private string tenTaiKhoan;

        public Account (int soDu, string tenTaiKhoan)
        {
            this.soDu = soDu;
            this.tenTaiKhoan = tenTaiKhoan;
        }

        public int SoDu { get => soDu; }
        public int MaPIN { set { maPIN = value; } }

        public int RutTien (int soTien)
        {
            if (soTien <= soDu)
            {
                soDu -= soTien;
                return soTien;
            }    
            else
            {
                Console.WriteLine("So tien trong tai khoan khong du de rut");
                return 0;
            }
        }

        public void ChuyenKhoan (Account p, int soTien)
        {
            int res = RutTien(soTien);
            if (res != 0)
            {
                Console.WriteLine("Chuyen tien thanh cong");
            }
            else
                Console.WriteLine("That bai");

        }

    }
}
