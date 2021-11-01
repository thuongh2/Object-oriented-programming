using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai8
    {
        static void Main()
        {
            short clothers;

            Console.Write("Nhap so ao: ");
            clothers = Convert.ToInt16(Console.ReadLine());

            const int price = 200000;
            const float pecent = 0.9F;
            const byte clotherDefault = 5; 

            float clotherPrice;

            if (clothers < clotherDefault)
                clotherPrice = clothers * price;
            else
            {
                short sale = (short)(clothers - clotherDefault);
                clotherPrice = (float)(clotherDefault * price + sale * price * pecent);
                clothers += (short)(clothers / clotherDefault);
            }

            Console.WriteLine("So tien phai tra {0}, tong so ao {1}", clotherPrice, clothers);

        }

     
    }
}
