using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class bai3
    {
        static void Main(string[] args)
        {
            short males;
            short females;
            short total;

            Console.Write("Nam sinh: ");
            males = Convert.ToInt16(Console.ReadLine());

            Console.Write("Nu sinh: ");
            females = Convert.ToInt16(Console.ReadLine());

            Console.Write("Si so: ");
            total = Convert.ToInt16(Console.ReadLine());

            float percentMale;
            float percentFemale;

            percentFemale = females / (float)total;
            percentMale = males / (float)total;

            Console.WriteLine("Nam sinh chiem {0}% trong lop, Nu sinh chiem {1}% trong lop", percentMale*100, percentFemale*100);

        }
    }
}
