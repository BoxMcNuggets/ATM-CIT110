using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM_CIT110
{
    class Program
    {
        public static void Main()
        {
            int amount = 10000, deposit, withdraw;
            int choice, pin = 0, number = 0;

            List<string> users = new List<string>();
            List<string> pass = new List<string>();

            Console.WriteLine();
            Console.Write("\tCreate Username:");
            string user = Console.ReadLine();
            users.Add(user);

            Console.WriteLine();
            Console.Write("\tCreate Password:");
            string password = Console.ReadLine();
            pass.Add(password);


            Console.Clear();

            Console.WriteLine();
            Console.WriteLine($"\tUsername: {user}");
            Console.WriteLine($"\tPassword: {password}");

            Console.WriteLine();
            Console.WriteLine("\tPlease Enter Username:");
            while (!users.Contains(Console.ReadLine()))
            {
                Console.WriteLine("\tYou have entered your username incorrectly, please try again:");
            }
            DisplayContinuePrompt();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine($"\tUsername: {user}");
            Console.WriteLine($"\tPassword: {password}");
            Console.WriteLine();
            Console.WriteLine("\tPlease Enter Password:");
            while (!pass.Contains(Console.ReadLine()))
            {
                Console.WriteLine("\tYou have entered your password incorrectly, please try again:");
            }
            DisplayContinuePrompt();
            Console.Clear();

            while (true)
            {
                Console.WriteLine("WELCOME TO YES BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        Console.WriteLine();
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n THANK YOU…");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            }
        }
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }
    }
}
