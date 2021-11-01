using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class Student
    {
        private int id;
        private string name;
        private string graded;
        private float math;
        private float literature;
        private float english;
        private float avgScore;

        public Student (int id, string name, float math, float literature, float english)
        {
            this.id = id;
            this.name = name;
            this.math = math;
            this.literature = literature;
            this.english = english;
        }

        public float AvgScore
        {
            get
            {
                avgScore = (math + literature + english) / 3;
                return avgScore;
            }
        }

        public string Graded
        {
            get
            {
                if (avgScore >= 8.5)
                    graded = "Gioi";
                else if (avgScore >= 6.5)
                    graded = "Kha";
                else if (avgScore >= 5)
                    graded = "Trung binh";
                else if (avgScore >= 3.5)
                    graded = "Yeu";
                else
                    graded = "Kem";
                return graded;
            }
        }

        public void XemThongTin()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} -{4} - {5} - {6} ", id, name, math, literature, english, AvgScore, Graded);
        }

        public void XetHocBong(string graded)
        {
            if (graded == "Gioi")
                Console.WriteLine("Duoc nhan hoc bong");
            else
                Console.WriteLine("Khong duoc nhan hoc bong");
        }

        public void XetLenLop(float avgScore)
        {
            if (avgScore >= 5)
                Console.WriteLine("Len lop thang");
            else if (avgScore >= 3.5)
                Console.WriteLine("Thi lai");
            else
                Console.WriteLine("O lai lop");
        }
    }
}
