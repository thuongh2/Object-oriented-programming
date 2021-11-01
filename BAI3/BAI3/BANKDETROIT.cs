using System;

namespace BAI3
{
    class BANKDETROIT
    {
        public static void addInforUser(out string name, out byte age, out string address)
        {
            do
            {
                Console.Write("Enter your name: ");
                name = Convert.ToString(Console.ReadLine());
            } while (string.IsNullOrEmpty(name));

            do
            {
                Console.Write("Enter your age: ");
                age = Convert.ToByte(Console.ReadLine());
                if (age < 18 || age > 60)
                    Console.WriteLine("InCorrect, Enter again!");
            } while (age < 18 || age > 60);

            do
            {
                Console.Write("Enter your address: ");
                address = Convert.ToString(Console.ReadLine());
            } while (string.IsNullOrEmpty(address));
            Console.WriteLine("Open new account successful...");

        }
        static void AcountDetail(string name, byte age, string address)
        {
            Console.WriteLine("Account detail: ");

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Adsress: {0}", address);
        }
        static void menuMain()
        {
            Console.WriteLine();
            Console.WriteLine("***Welcome to Detroit United Bank***");
            Console.WriteLine("1. Open");
            Console.WriteLine("2. Account");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
        }
        static void menuAccount()
        {
            Console.WriteLine();
            Console.WriteLine("***Execute transaction***");
            Console.WriteLine("2.1: Deposit");
            Console.WriteLine("2.2: Withdraw");
            Console.WriteLine("2.3: Show");
            Console.WriteLine("2.4: Quit");

            Console.Write("Input transaction type : ");
        }
        static void Main()
        {
            string yourChoice;
            string name;
            byte age;
            string address;
            int money = 0;
            byte countWithDraw = 0;
            int withDraw;

            while (true)
            {
                menuMain();
                yourChoice = Convert.ToString(Console.ReadLine());

                switch (yourChoice)
                {
                    case "Open":
                    case "open":
                    case "1":
                        addInforUser(out name, out age, out address);
                        AcountDetail(name, age, address);
                        break;

                    case "Account":
                    case "account":
                    case "2":

                        while (true)
                        {
                            menuAccount();

                            string selectAccount;
                            selectAccount = Convert.ToString(Console.ReadLine());

                            switch (selectAccount)
                            {
                                case "Deposit":
                                case "deposit":
                                case "1":

                                    int depositMoney;
                                    do
                                    {
                                        Console.Write("Enter the amount to deposit: ");
                                        depositMoney = Convert.ToInt32(Console.ReadLine());

                                        if (depositMoney > 0 && depositMoney < 2000000)
                                        {
                                            money += depositMoney;
                                            Console.WriteLine("Deposit Success!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("InValid!");
                                        }
                                    } while (depositMoney < 0 || depositMoney > 2000000);

                                    break;
                                case "Withdraw":
                                case "withdraw":
                                case "2":

                                    if (money == 0)
                                    {
                                        Console.WriteLine("So du tai khoan la 0, Hay nap tien vao tai khoan");
                                        break;
                                    }

                                    do
                                    {
                                        Console.Write("Enter the amount to withdraw: ");
                                        withDraw = Convert.ToInt32(Console.ReadLine());
                                        if (withDraw >= money)
                                        {
                                            Console.WriteLine("So du khong du, Hay nhap lai: ");
                                        }

                                    }
                                    while (withDraw >= money);

                                    money -= withDraw;
                                    countWithDraw++;

                                    Console.WriteLine("Successful!");
                                    Console.WriteLine("Amout WithDraw: {0}, amount of money left: {1}", withDraw, money);

                                    break;

                                case "Show":
                                case "show":
                                case "3":
                                    Console.WriteLine("So tien hien co", money);
                                    Console.WriteLine("So lan rut {0} ", countWithDraw);
                                    break;

                                default:
                                    Console.WriteLine("InCorrect!");
                                    break;

                            }
                            if (selectAccount == "Quit" || selectAccount == "4" || selectAccount == "quit")
                            {
                                Console.Write("Ban co muon thoat chuong trinh (c/k): ");

                                char selectExitA;
                                selectExitA = Convert.ToChar(Console.ReadLine());

                                if (selectExitA == 'c')
                                    break;
                            }

                        }
                        break;
                    case "Exit":
                    case "exit":
                    case "3":
                        Console.Write("Ban co muon thoat chuong trinh (c/k): ");

                        char selectExit;
                        selectExit = Convert.ToChar(Console.ReadLine());

                        if (selectExit == 'c')
                            System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("InCorrect!");
                        break;
                }

            }
        }
    }
}
