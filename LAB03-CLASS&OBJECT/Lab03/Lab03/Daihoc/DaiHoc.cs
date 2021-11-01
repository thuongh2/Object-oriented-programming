using System;
using System.Collections.Generic;
using System.Text;
using Lab03.Thisinh;

namespace Lab03.Daihoc
{
    class DaiHoc
    {
        public string TenTruong;
        public float diemChuan;

        public void XetTuyen(ThiSinh thisinh)
        {
            if (thisinh.TinhDiemXetTuyen() > diemChuan && thisinh.KiemTraDiemLiet() == false)
                Console.WriteLine("Chuc mung ban {0}, so bao danh {1}, da trung tuyen truong {2}", thisinh.name, thisinh.SBD, TenTruong);
            else
                Console.WriteLine("Rat tiec ban {0}, so bao danh {1}, chua du dieu kien trung tuyen truong {2}", thisinh.name, thisinh.SBD, TenTruong);

        }
    }
}
