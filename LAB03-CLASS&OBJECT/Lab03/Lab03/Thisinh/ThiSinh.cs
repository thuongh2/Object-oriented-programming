using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03.Thisinh
{
    class ThiSinh
    {
        public string name;
        public string SBD;
        public float score1, score2, score3;
        public string isGioi;
        public string isUuTien;
    
        public float TinhDiemXetTuyen()
        {
            float DXT = score1 + score2 + score3;
            if (isGioi == "Co")
                DXT += 1;
            if (isUuTien == "Co")
                DXT += (float)0.5;
            return DXT;
        }

        public bool KiemTraDiemLiet ()
        {
            if (score1 == 0 || score2 == 0 || score3 == 0)
                return true;
            return false;
        }
              
        public void NhapThongTin ()
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            
            Console.Write("Nhap SBD: ");
            SBD = Console.ReadLine();

            Console.Write("Nhap diem 1: ");
            score1 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Nhap diem 2: ");
            score2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap diem 3: ");
            score3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Co la hoc sinh gioi: ");
            isGioi = Console.ReadLine();

            Console.Write("Co la hoc thuoc dien uu tien: ");
            isUuTien = Console.ReadLine();
        }

    }
}
