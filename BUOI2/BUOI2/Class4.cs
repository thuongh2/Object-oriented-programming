using System;
using System.Collections.Generic;
using System.Text;

namespace BUOI2
{
    class Class4
    {
        static void Main ()
        {
            char charLanguage;
            string Language;

            Console.Write("Nhap ki tu: ");
            charLanguage = Convert.ToChar(Console.ReadLine());

            switch (charLanguage)
            {
                case 'a':
                case 'A':
                    Language = "Ada";
                    break;
                case 'b':
                case 'B':
                    Language = "Basic";
                    break;
                case 'c':
                case 'C':
                    Language = "Cobol";
                    break;
                case 'd':
                case 'D':
                    Language = "Android";
                    break;
                case 'f':
                case 'F':
                    Language = "Fortran";
                    break;
                case 'w':
                case 'W':
                    Language = "Windows Phone";
                    break;
                default:
                    Language = "Ban da nhap sai";
                    break;

            }
            Console.WriteLine(Language);

        }
    }
}
