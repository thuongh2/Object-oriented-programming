using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Rectangle
    {
        public ushort height;
        public ushort weight;

        public int DoPerimeter()
        {
            return (height + weight) * 2;
        }

        public int DoArea()
        {
            return (height * weight);
        }
    }
}
