using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class AccountManagement
    {
        static void Main()
        {
            Account acc1 = new Account(20000, "Thuong");
            Account acc2 = new Account(30000, "Thuong 2");

            acc1.MaPIN = 113;
            Console.WriteLine("So du: {0}", acc1.SoDu);

            acc1.RutTien(10000);

            acc1.ChuyenKhoan(acc2, 10000);

            Console.WriteLine("So du: {0}", acc2.SoDu);

        }


    }
}
