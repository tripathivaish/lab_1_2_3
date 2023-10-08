using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENTS_2
{
    class BankAccount1
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount1(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }

    sealed class SavingsAccount : BankAccount1
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public void CalculateInterest(int numberOfMonths)
        {
            double monthlyInterestRate = InterestRate / 12;
            double interestEarned = Balance * monthlyInterestRate * numberOfMonths;
            Balance += interestEarned;

            Console.WriteLine($"Interest calculated for {numberOfMonths} months. New balance: ${Balance:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account Number: ");
            int account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Initial Balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Interest Rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            SavingsAccount savingsAccount = new SavingsAccount(account, balance, rate);

            // Calculate interest for 6 months
            savingsAccount.CalculateInterest(6);
            Console.ReadKey();
        }
    }
}
