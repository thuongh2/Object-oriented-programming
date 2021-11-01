using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Date
    {
        public byte day;
        public byte month;
        public ushort year;

        public void InputDate()
        {
            Console.Write("Enter day: ");
            day = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter month: ");
            month = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter year: ");
            year = (ushort)Convert.ToInt16(Console.ReadLine());
        }

        public byte AfterDay ()
        {
            if (month ==2)
            {
                if (year % 4 ==0 && year %100 != 0 || year % 400 == 0)
                {
                    if (day == 29)
                        return 1;

                }
                else
                {
                    if (day == 28)
                        return 1;
                }
            }
            else if (month == 4 || month ==6 || month == 9 ||  month ==11)
            {
                if (day == 30)
                    return 1;
            }
            else
            {
                if (day == 31)
                    return 1;
            }
            return ++day;
        }

        public byte AfterDays()
        {
            Console.Write("Nhap ngay muon tinh: ");
            byte afterDays = Convert.ToByte(Console.ReadLine());

            return (byte)(AfterDay() + afterDays - 1);
        }

        public void ShowDate()
        {
            Console.WriteLine("{0}/{1}/{2}", day, month, year);
        }
    }
}
