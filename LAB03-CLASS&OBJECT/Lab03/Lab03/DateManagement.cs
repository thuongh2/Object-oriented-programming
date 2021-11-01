using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class DateManagement
    {
        static void Main ()
        {
            Date date = new Date();

            date.InputDate();

            byte afterDay = date.AfterDay();
            Console.WriteLine("Ngay ke tiep cua hien tai {0}", afterDay);

            byte afterDays = date.AfterDays();
            Console.WriteLine("Ngay ke tiep {0}", afterDays);

            date.ShowDate();
        }
    }
}
