using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class PhanSo
    {
        public int tu;
        public int mau;

        public PhanSo ()
        {
            this.tu = 1;
            this.mau = 1;
        }

        public PhanSo (int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }


        public PhanSo CongPhanSo(PhanSo ps2)
        {
            PhanSo temp = new PhanSo();
            temp.tu = tu * ps2.mau + ps2.tu * mau;
            temp.mau = mau * ps2.mau;
            return temp;
        }

        public void RutGonPhanSo()
        {
            int uc = ucln(tu, mau);
            tu = tu / uc;
            mau = mau / uc;
        }
        private int ucln (int tu, int mau)
        {
            int temp = 1;
            while (temp != 0)
            {
                temp = tu % mau;
                tu = mau;
                mau = temp;
            }
            return tu;
        }

        public void HienThiPhanSo()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
    }
}
