using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class RectangleManagement
    {
        static void Main ()
        {
            Rectangle rectangle = new Rectangle();

            rectangle.height = 10;
            rectangle.weight = 5;

            int Perimeter = rectangle.DoPerimeter();
            Console.WriteLine("Chu vi hinh chu nhat {0}m", Perimeter);

            int Area = rectangle.DoArea();
            Console.WriteLine("Dien tich hinh chu nhat {0}m2", Area);
        }
    }
}
