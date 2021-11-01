using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Point_3
{
    class PointManagement
    {
        static void Main()
        {
            Point3D p1 = new Point3D();
            Point3D p2 = new Point3D(2);
            Point3D p3 = new Point3D(-1, -4, 7);

            p1.HienThiToaDo();
            p2.HienThiToaDo();
            p3.HienThiToaDo();
        }
    }
}
