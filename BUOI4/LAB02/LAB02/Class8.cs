using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace LAB02
{
    class Class8
    {
        static byte ValidateEmail (string email)
        {
            if (email.Contains(".") && email.Contains('@'))
                return 1;
            return 0;
        }

        static int ValidatePassword(string password)
        {
            bool Upcase = false;
            bool Lowercase = false;
            bool special = false;

            if (password.Length < 8)
                return 0;
            foreach (char item in password)
            {
                if (item >= 65 && item <= 90)
                    Upcase = true;
                else if (item >= 97 && item <= 122)
                    Lowercase = true;
                else if (item >= 33 && item <= 47 || item >=60 && item <=64)
                    special = true;
            }
            if (special == true && Upcase == true && Lowercase == true)
                return 1;
            return 0;
        }

        static int ValidateConfirmPassword(string ConfirmPassword, string password)
        {
            if (ConfirmPassword.CompareTo(password) == 0)
                return 1;
            return 0;
        }

        static void Main()
        {


            string email;
            string password;
            string ConfirmPassword;

            do
            {
                Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();

                byte checkEmail = ValidateEmail(email);

                if (checkEmail == 0)
                    Console.WriteLine("InCorrect! Enter Again!");

            } while (ValidateEmail(email)==0);

            do
            {
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();

                if (ValidatePassword(password) == 0)
                    Console.WriteLine("InCorrect! Enter Again!");

            } while (ValidatePassword(password) == 0);

            do
            {
                Console.WriteLine("Enter again your password: ");
                ConfirmPassword = Console.ReadLine();

                if (ValidateConfirmPassword(ConfirmPassword, password) == 0)
                    Console.WriteLine("InCorrect! Enter Again!");

            } while (ValidateConfirmPassword(ConfirmPassword, password) == 0);

            Console.WriteLine("Register Successfully");
        }
    }
}
