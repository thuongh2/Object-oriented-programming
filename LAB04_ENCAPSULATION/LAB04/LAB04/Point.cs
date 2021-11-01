using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class Point
    {
        private char pointName;
        private int x;
        private int y;

        public Point()
        {

        }

        public Point(char pointName ,int X, int Y)
        {
            this.pointName = pointName;
            this.x = X;
            this.y = Y;
        }

        public char PointName { get => pointName; set { pointName = value; } }
        public int X { get => x; set { x = value; } }
        public int Y { get => y; set { y = value; } }

        public void Move(int ax, int ay)
        {
            x += ax;
            y += ay;
        }

        public void Show ()
        {
            Console.WriteLine("{0}({1},{2})", pointName, x, y);
        }

        public float GetLenght(Point p)
        {
            float d = (float)Math.Sqrt((p.X - X) * (p.X - X) + (p.y - y) * (p.y - y));
            return d;
        }

        public Point MidPoint(Point p)
        {
            Point temp = new Point();

            temp.pointName = 'M';
            temp.x = (x + p.x) / 2;
            temp.y = (y + p.y) / 2;

            return temp;
        }

    }
}
