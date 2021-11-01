using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    class Rectangle
    {
        private int lenght;
        private int width;

        public Rectangle ()
        {

        }

        public Rectangle(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }

        public int Lenght
        { 
            get => lenght;
            set
            {
                if (value < 0)
                    lenght = 0;
                else
                    lenght = value;
            }
        }

        public int Width
        {
            get => lenght;
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }

        public int TinhDienTich()
        {
            return lenght * width;
        }

        public int TinhChuVi()
        {
            return (lenght + width) * 2;
        }

        public void toString()
        {
            Console.WriteLine("Hinh chu nhat co dien tich {0} va chu vi {1}", TinhDienTich(), TinhChuVi());
        }
    }
}
