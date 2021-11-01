using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class TimeManagement
    {
        static void Main()
        {
            Time t1 = new Time(23, 59, 58);

            t1.Hours = 25;
            t1.Minute = 64;
            t1.Second = 90;

            t1.Show12Hours();
            t1.Show24Hours();

            for (byte i = 0; i < 5; i++)
            {
                t1.Add1Second();
                t1.Show12Hours();
                t1.Show24Hours();
            }
        }
    }
}
