using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BankingSystem
{
    public class Account {
        public int AccountNumber;
        public string AccountHolderName;
        public decimal Balance;

        IAccount _Account;

        public Account(IAccount account,int AccountNumber,string AccountHolderName,int Balance)
        {
            _Account = account;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
            this.AccountNumber = AccountNumber;
        }
        public void Deposit(int amount)
        {
            _Account.Deposit(this,amount);
        }
        public void Withdraw(int amount)
        {
            _Account.Withdraw(this, amount);
        }
        public void GetBalance()
        {
            _Account.GetBalance(this);
        }


    }

    public class Bank 
    {
        private List<Account> accounts = new List<Account>();
        public void AddAccount(Account account)
        {
            accounts.Add(account);
            Console.WriteLine($"Account added: {account.AccountNumber}, {account.AccountHolderName}");
        }

        public  void PrintAllAccounts()
        {
            foreach(var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Account Holder Name : {account.AccountHolderName}");
            }
        }

        public Account SearchAccountbyID(Bank bank,int Id)
        {
            return accounts.FirstOrDefault(bank => bank.AccountNumber == Id);
        }
    }
}
