using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    class Worker
    {
        public string name;
        public short year;
        public string job;
        public string workPlace;

        public void Input()
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your year of birth: ");
            year = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your job: ");
            job = Console.ReadLine();
        }

        public void FindWorkplace()
        {
            switch (job)
            {
                case "Giao duc":
                    workPlace = "Truong hoc";
                    break;
                case "Y te":
                    workPlace = "Benh vien";
                    break;
                case "Luat":
                    workPlace = "Toa an";
                    break;
                case "Cong so":
                    workPlace = "Van phong";
                    break;
                case "Khac":
                    workPlace = "Khong biet";
                    break;
            }
        }

        public string StudyOrWork()
        {
            const short yearCurrent = 2021;
            if (yearCurrent - year < 20)
                return "dang hoc";
            else
                return "dang lam viec";
        }

        public void Output()
        {
            Console.WriteLine("Ban ten la: {0}, Ban dang {1}, ve {2}, tai {3}", name, StudyOrWork(), job, workPlace);
        }
    }
}
