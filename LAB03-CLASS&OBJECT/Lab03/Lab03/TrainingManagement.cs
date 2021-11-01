using System;
using System.Collections.Generic;
using System.Text;
using Lab03.Thisinh;
using Lab03.Daihoc;

namespace Lab03
{
    class TrainingManagement
    {
        static void Main()
        {
            ThiSinh thisinh = new ThiSinh();
            DaiHoc HSU = new DaiHoc();
            DaiHoc UTE = new DaiHoc();
            DaiHoc SGU = new DaiHoc();

            thisinh.NhapThongTin();

            HSU.TenTruong = "Truong Dai hoc Hoa Sen";
            HSU.diemChuan = 15;

            HSU.XetTuyen(thisinh); 

            UTE.TenTruong = "Truong Dai hoc SPKT";
            UTE.diemChuan = 23;

            UTE.XetTuyen(thisinh);

            SGU.TenTruong = "Truong Dai hoc Sai Gon";
            SGU.diemChuan = (float)15.5;

            SGU.XetTuyen(thisinh);

        }
    }
}
