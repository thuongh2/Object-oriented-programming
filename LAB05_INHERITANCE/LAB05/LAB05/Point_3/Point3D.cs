using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Point_3
{
    class Point3D: Point2D
    {
        private int z;

        public Point3D():base(0,0)
        {

        }

        public Point3D(int z) : base(0, 0)
        {
            this.z = z;
        }

        public Point3D(int x, int y, int z): base(x, y)
        {
            this.z = z;
        }

        public int Z { get => z; set { z = value; } }

        public override void HienThiToaDo()
        {
            base.HienThiToaDo();
            Console.WriteLine(z);
        }

    }
}
