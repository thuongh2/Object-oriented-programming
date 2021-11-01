using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai5
    {
        static void Main(string[] args)
        {
            int deposits;
            short month;
            
            const short temp = 12;

            Console.Write("So tien gui: ");
            deposits = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ky han: ");
            month = Convert.ToInt16(Console.ReadLine());

            float moneyMonth = (deposits * (float) 0.07) / (float) temp;
            float totalMoney = (float) deposits + moneyMonth * month;


            Console.WriteLine("Lai xuat hang thang {0}VND, Tong tien gui sau ki han {1}VND", moneyMonth, totalMoney);


        }
    }
}
