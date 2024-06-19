using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            bool validOption = false;
            int option = 0;
            bool exit = true;
            string? owner = null;
            double inibalance;
            bool validini = false;
            List<Account> accounts = new List<Account>();
            double amount = 0;
            bool validamount = false;
            bool validaccount = false;
            int accountnumber;

            Console.WriteLine("Welcome to the Bank!");
            Console.WriteLine();
            while (exit)
            {
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("1 - View accounts");
                Console.WriteLine("2 - Create an account");
                Console.WriteLine("3 - Deposit");
                Console.WriteLine("4 - Withdraw");
                Console.WriteLine("5 - Exit");
                Console.Write("Option: ");
                validOption = int.TryParse(Console.ReadLine(), out option);
                if (validOption && (option > 0 && option < 6))
                {
                    switch (option)
                    {
                        case 1:
                            if (Account.numacc == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("No Accounts found, please first creat an account ");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("here is your accounts: ");
                                foreach (Account i in accounts)
                                {
                                    Console.WriteLine($"The account {i.AccountNumber}: {i.OwnerName}     balance: {i.Balance}");
                                }
                                Console.WriteLine();    
                            }

                            break;


                        case 2: // creat accounts
                            Console.WriteLine();
                            while (string.IsNullOrEmpty(owner))
                            {
                                Console.WriteLine("Enter the account owners name: ");
                                owner = Console.ReadLine();
                            }
                            while (true)
                            {
                                Console.WriteLine("Enter the initial balance: ");

                                validini = double.TryParse(Console.ReadLine(), out inibalance);
                                if (!validini)
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                }


                                if (validini && inibalance < Account.MinimumInitialBalance)
                                {
                                    Console.WriteLine("The min initial balance is $1000");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Account acc = new Account(owner, inibalance);
                                    Console.WriteLine();
                                    accounts.Add(acc);
                                    owner = null;
                                    break;
                                }
                            }
                            break;
                        case 3: // deposit
                            while(true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter the account number: ");
                                validaccount = int.TryParse(Console.ReadLine(), out accountnumber);
                                if (validaccount) break;
                                Console.WriteLine("Enter a valid account number");
                            }
                           
                            if (validaccount)
                            {
                                foreach (Account i in accounts)
                                {
                                    if (i.AccountNumber == accountnumber)
                                    {
                                        while(true)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter the deposit amount: ");
                                            validamount = double.TryParse(Console.ReadLine(), out amount);
                                            Console.WriteLine();
                                            if (validamount) break;
                                            Console.WriteLine("Enter a valid amount for deposit");
                                        }
                                       
                                        Console.WriteLine("successful");
                                        i.Deposit(amount);
                                        Console.WriteLine();
                                        Console.WriteLine($"The account {i.AccountNumber}: {i.OwnerName}     balance: {i.Balance}");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Account not found. Please try again.");
                                            Console.WriteLine();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("enter a valid account number");
                            }
                            
                            break;
                        case 4: // withdraw
                            while (true)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter the account number: ");
                                validaccount = int.TryParse(Console.ReadLine(), out accountnumber);
                                if (validaccount) break;
                                Console.WriteLine("Enter a valid account number");
                            }

                            if (validaccount)
                            {
                                foreach (Account i in accounts)
                                {
                                    if (i.AccountNumber == accountnumber)
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter the withdraw amount: ");
                                            validamount = double.TryParse(Console.ReadLine(), out amount);
                                            Console.WriteLine();
                                            if (validamount) break;
                                            Console.WriteLine("Enter a valid amount for withdraw");
                                        }

                                        try {
                                            i.Withdraw(amount);
                                            Console.WriteLine("Successful");
                                        }
                                        catch( Exception e) {
                                            Console.WriteLine(e.Message);
                                        }

                                        Console.WriteLine();
                                        Console.WriteLine($"The account {i.AccountNumber}: {i.OwnerName}     balance: {i.Balance}");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Account not found. Please try again.");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("enter a valid account number");
                            }

                            break;
                        case 5:
                            Console.WriteLine("See you soon!");
                            exit = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid option");
                    Console.WriteLine();
                }
            }
            




        }
    }
}
