using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class PhuongTrinhManagement
    {
        static void Main ()
        {
            PhuongTrinh pt1 = new PhuongTrinh(0,0);
            PhuongTrinh pt2 = new PhuongTrinh(1,2,3);

            short flag = (short)pt1.GiaiPTBacI();
            pt1.KetLuan(flag);

            flag = (short)pt2.GiaiPTBacII();
            pt2.KetLuan(flag);
        }
    }
}
