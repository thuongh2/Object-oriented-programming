using System;
using System.Collections.Generic;
using System.Text;

namespace BAI1
{
    class Bai12
    {    
        static void Main ()
        {
            Console.OutputEncoding = Encoding.UTF8;

            short year;
            Console.Write("Nhap nam sinh cua ban: ");
            year = (short)Convert.ToInt16(Console.ReadLine());

            if (year < 1800)
            {
                Console.WriteLine("Hay nhap nam tu 1800");
                return;
            }
            
            short Can = (short)(year % 10);

            short Chi = (short)((short)(year - 1800) % 12);

            string[] ArrayCan = { "Canh", "Tân", "Nhăm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] ArrayChi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tị", "Ngọ", "Mùi" };

            Console.WriteLine("{0} {1}", ArrayCan[Can], ArrayChi[Chi]);

        }
    }
}
