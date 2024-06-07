using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public interface IAccount
    {
        void Deposit(Account acc,int Amount);
        void Withdraw(Account Acc,int Amount);
        void GetBalance(Account acc);
    }

    public class SavingsAccount : IAccount
    {
        public void Deposit(Account acc,int amount)
        {
             acc.Balance += amount;
             Console.WriteLine($"Savings Account: Deposited {amount}. New Balance: {acc.Balance}");
            
        }
        public void Withdraw(Account acc, int amount)
        {
            if (acc.Balance >= amount)
            {
                acc.Balance -= amount;
                Console.WriteLine($"Savings Account: Withdrew {amount}. New Balance: {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Savings Account: Insufficient funds");
            }

        }
        public void GetBalance(Account acc)
        {
            Console.WriteLine($"Savings Account available balance : {acc.Balance}");
        }
    }
    public class CurrentAccount : IAccount 
    {
        public void Deposit(Account acc, int amount)
        {
            acc.Balance += amount;
            Console.WriteLine($"Current Account: Deposited {amount}. New Balance: {acc.Balance}");
        }
        public void Withdraw(Account acc,int amount)
        {
            if (acc.Balance >= amount)
            {
                acc.Balance -= amount;
                Console.WriteLine($"Current Account: Withdrew {amount}. New Balance: {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Current Account: Insufficient funds");
            }
        }
        public void GetBalance(Account acc)
        {
            Console.WriteLine($"Current Account available balance : {acc.Balance}");
        }
    }

}
