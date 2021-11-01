using System;

namespace Lab03
{
    class StudentManagement
    {
        static void Main()
        {
            //Khoi tao 3 doi tuong student
            Student Student1 = new Student();
            Student Student2 = new Student();
            Student Student3 = new Student();

            //Them thong tin sinh vien
            Student1.StudentId = "20133012";
            Student1.StudentName = "Vo Hoai Thuong";

            //Xuat thong tin sinh vien 
            Student1.SayHello();

            //Them thong tin sinh vien
            Student2.StudentId = "20133006";
            Student2.StudentName = "Huynh Hao Nhi";

            //Xuat thong tin sinh vien 
            Student2.SayHello();

            //Them thong tin sinh vien
            Student3.StudentId = "20133024";
            Student3.StudentName = "Nguyen Van Dung";

            //Xuat thong tin sinh vien 
            Student3.SayHello();
        }
    }
}
