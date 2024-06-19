using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        public int AccountNumber { get; set; } 
        public string OwnerName { get; set; } 
        public double Balance { get; set; }

        public const int MinimumInitialBalance = 1000;
        public static int numacc = 0;

        // constructors 
        //public Account() : this("Unknown", 0) { }
        //public Account(string name) : this(name, 0) { }
        public Account(string name, double balance)
        {
            this.OwnerName = name;
            this.Balance = balance;

            Random rnd = new Random();
            this.AccountNumber = rnd.Next(100000, 999999);
            numacc++;
            Console.WriteLine($"The account {this.AccountNumber}: {this.OwnerName}     {this.Balance}");
        }

        // methods 
        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"Deposit of +{amount} successful. Your new balance is {this.Balance}.");
        }

        public void Withdraw(double amount)
        {
            if (amount > this.Balance) {
                throw new Exception("You cant withdraw more than your balance!");
            }
            this.Balance -= amount;
            Console.WriteLine($"Withdraw of -{amount} successful. Your new balance is {this.Balance}.");
        }

        
    }
}