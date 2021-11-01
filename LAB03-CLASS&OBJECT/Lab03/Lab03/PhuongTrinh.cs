using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class PhuongTrinh
    {
        public float a;
        public float b;
        public float c;
        private float delta;
        private float x1;
        private float x2;

        public PhuongTrinh(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public PhuongTrinh(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private void TimDelta()
        {
            delta = (b * b - 4 * a * c);
        }

        public int GiaiPTBacI()
        {
            if (a == 0 && b == 0)
                return -1;
            else if (a == 0 && b != 0)
                return 0;
            else
            {
                x1 = x1 = -b / a;
                return 1;
            }
        }

        public int GiaiPTBacII()
        {
            TimDelta();
            if (delta < 0)
                return 0;
            else if (delta == 0)
            {
                x1 = x2 = -b / 2 * a;
                return 1;
            }
            else
            {
                x1 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                return 2;
            }
        }

        public void KetLuan(short flag)
        {
            if (flag == -1)
                Console.WriteLine("Phuong trinh vo so nghiem");
            else if (flag == 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (flag == 1)
                Console.WriteLine("Phuong trinh co nghiem: x={0}", x1);
            else
                Console.WriteLine("Phuong trinh co 2 nghiem x1= {0}, x2= {1}", x1, x2);

        }


    }
}
