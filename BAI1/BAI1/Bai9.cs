using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai9
    {
        static int slovePrice (short hours)
        {
            const int priceOneHour = 40000;
            const int price24Hour = 200000;

            if (hours <= 3)// neu duoi 3h tinh 40000
                return priceOneHour;
            else
            {
                if (hours < 24)
                    return priceOneHour + (hours - 3) * 10000;// them 10000 cho moi gio (vd: 4 gio = 3 gio 40000 + 1 gio 10000)
                else
                    return price24Hour; // neu 24 gio tro len thì tinh 200000
            }  
        }
        static void Main ()
        {
            //input hours (short), output money (int)
            short hours;
            int price;

            Console.Write("Nhap so gio do xe: ");
            hours = Convert.ToInt16(Console.ReadLine());

            price = (int)slovePrice(hours);

            Console.WriteLine("So tien do xe: {0}", price);

    }
    }
       
}
