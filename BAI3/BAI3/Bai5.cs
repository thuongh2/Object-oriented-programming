using System;
using System.Text;

namespace BAI3
{
    class Bai5
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const ushort passWord = 12345;
            ushort passWordUser;
            byte count = 0;

            do
            {
                Console.Write("Enter your password: ");
                passWordUser = (ushort)Convert.ToInt16(Console.ReadLine());

                if (passWordUser == passWord)
                {
                    Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    Console.WriteLine("Mật khẩu không hợp lệ");
                    count++;
                }
            } while (passWordUser != passWord && count < 3);
        }
    }
}
