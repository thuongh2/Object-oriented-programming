using System;
using System.Collections.Generic;
using System.Text;

namespace LAB02
{
    class Class2
    {
        static byte KiemTraTangDan(int inumber)
        {
            byte[] arr = new byte[11];
            byte count = 0;
            while (inumber > 0)
            {
                arr[count] = (byte)(inumber % 10);
                inumber /= 10;
                count++;
            }
            for (byte i = 0; i < count; i++)
            {
                if (arr[i] < arr[i + 1])
                    return 0;

            }

            return 1;
        }

        static void DemSoChanLe(int inumber, ref int DemChan, ref int DemLe)
        {
            byte[] arr = new byte[11];
            byte count = 0;
            while (inumber > 0)
            {
                arr[count] = (byte)(inumber % 10);
                inumber /= 10;
                count++;
            }

            for (byte i = 0; i < count; i++)
            {
                if (arr[i] % 2 == 0)
                    DemChan++;
                else
                    DemLe++;
            }

        }

        static void Main()
        {
            int inumber;
            Console.Write("Nhap so nguyen: ");
            inumber = Convert.ToInt32(Console.ReadLine());

            byte check = KiemTraTangDan(inumber);

            if (check == 1)
                Console.WriteLine("So {0} la so co cac ki tu so tang dan", inumber);
            else
                Console.WriteLine("So {0} la so khong co cac ki tu so tang dan", inumber);
            int DemChan = 0, DemLe = 0;

            DemSoChanLe(inumber, ref DemChan, ref DemLe);

            Console.WriteLine("n= {0} co {1} so chan, {2} so le", inumber, DemChan, DemLe);


        }
    }
}
