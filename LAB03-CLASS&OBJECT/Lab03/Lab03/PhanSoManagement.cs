using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class PhanSoManagement
    {
        static void Main ()
        {
            PhanSo p1 = new PhanSo(5, 6);
            PhanSo p2 = new PhanSo(0,0);

            PhanSo p3;

            p3 = p1.CongPhanSo(p2);

            p3.RutGonPhanSo();

            p3.HienThiPhanSo();

        }
    }
}
