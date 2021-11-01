using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class StudentManagement
    {
        static void Main ()
        {
            Student sv = new Student(20133012, "Hoai Thuong", 8, 9, 10);

            sv.XemThongTin();

            sv.XetHocBong(sv.Graded);

           // sv.XetLenLop();
        }
    }
}
