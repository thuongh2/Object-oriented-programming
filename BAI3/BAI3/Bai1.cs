using System;

namespace BAI3
{
    class Bai1
    {
        static void Main()
        {
            for (byte i = 100; i >= 5; i--)
            {
                if (i % 5 == 0)
                    Console.Write("{0} ", i);
            }
        }
    }
}
