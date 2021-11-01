using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class PointManagement
    {
        static void Main()
        {
            Point p1 = new Point('A', 4, 6);
            Point p2 = new Point('B', 7,8);

            p1.PointName = 'C';
            p1.X = 3;
            p1.Y = 5;

            p1.Show();

            p2.Move(2, 2);
            p2.Show();

            float d = p1.GetLenght(p2);
            Console.WriteLine(d);

            p1.MidPoint(p2).Show();
        }
    }
}
