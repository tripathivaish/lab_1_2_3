using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    internal class Bank_account
    {
        int Account_no;
        string Account_holder_name;
        double Balance;

        public Bank_account(int acc_no, string acc_name, double balance)
        {
            Account_no = acc_no;
            Account_holder_name = acc_name;
            Balance = balance;
        }

        public void displayDetails()
        {
            Console.WriteLine("Account number: " + Account_no);
            Console.WriteLine("Acount holder name: " + Account_holder_name);
            Console.WriteLine("Balance: " + Balance);
        }
        public void deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit amount" + Balance);
            }
            else
            {
                Console.WriteLine("No deposite amount");
            }
        }

        public void withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawl amount: " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }
        static void Main(string[] args)
        {
            Bank_account b = new Bank_account(1801036721, "Vandana", 3000);
            b.displayDetails();
            b.deposit(1000);
            b.withdraw(2000);
            Console.WriteLine("\nAfter perform certain operations");
            b.displayDetails();
        }
    }
}



