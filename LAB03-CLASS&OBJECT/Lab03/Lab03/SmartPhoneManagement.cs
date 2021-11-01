using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class SmartPhoneManagement
    {
        static void Main ()
        {
            SmartPhone s1 = new SmartPhone();
            SmartPhone s2 = new SmartPhone("SamSungJ4", "SamSung", 16, 3200000);

            s1.InputPhone();

            s1.ShowInfo();
            s2.ShowInfo();

            s1.ComparePhone(s2);

        }
    }
}
