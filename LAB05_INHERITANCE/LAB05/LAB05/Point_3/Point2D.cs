using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Point_3
{
    class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set { x = value; } }
        public int Y { get => y; set { y = value; } }

        public virtual void HienThiToaDo()
        {
            Console.Write("{0}, {1}, ", x, y);
        }
    }
}
