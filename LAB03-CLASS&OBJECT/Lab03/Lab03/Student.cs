using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Student
    {
        public string StudentId;
        public string StudentName;

        public void SayHello()
        {
            Console.WriteLine("Hello! I am {0}, ID number {1}", StudentName, StudentId);
        }
    }
}
