using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai16
    {
        static void Main()

        {
            Console.OutputEncoding = Encoding.UTF8;
            Random r = new Random();
            int price = r.Next(10000, 1000000);

            short N = 10;
            int predictPrice;

            while( N >= 0 )
            {
                Console.WriteLine(N);
                Console.WriteLine(price);
                

                Console.Write("Hãy nhập giá dự đoán: ");
                predictPrice = Convert.ToInt32(Console.ReadLine());

                if (predictPrice > price)
                {
                    Console.WriteLine("Giá mua nhập vào cao hơn giá trị, Hãy nhập lại giá");
                    N--;
                }
                else if (predictPrice < price)
                {
                    Console.WriteLine("Giá mua nhập vào thấp hơn giá trị, Hãy nhập lại giá");
                    N--;
                }    
                else
                {
                    Console.WriteLine("Nhập đúng, số điểm {0}, số lần sai {1}", N, 10 - N);
                    break;
                }    
            }    

        }
    }
}
