using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05
{
    class Square:Rectangle
    {
        private int edge;

        public Square(int edge): base(edge, edge)
        {
            this.edge = edge;
        }

        public int Edge
        {
            get => edge;
            set
            {
                if (value < 0)
                    edge = 0;
                else
                    edge= value;
            }
        }

        public void toString ()
        {
            Console.WriteLine("Hinh chu nhat co dien tinh {0} va chu vi {1}", base.TinhDienTich(), base.TinhChuVi());
        }
    }
}
