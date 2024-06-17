namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool exit = false;
            Bank bank = new Bank();
            while (!exit)
            {
                DisplayOptions();
                int option = Convert.ToInt32(Console.ReadLine());
            
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter which type of bank account you want to create : ");
                        Console.WriteLine("1.Savings Account");
                        Console.WriteLine("2.Current Account");
                        Console.WriteLine("3.Back menu");
                        int createValue = Convert.ToInt32(Console.ReadLine());
                        switch (createValue)
                        {
                            case 1:
                                AddSavingsBank(bank);
                                break;
                            case 2:
                                AddCurrentBank(bank);
                                break;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("Invalid input please enter the correct option");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("select any of the following account to perform the operation");
                        bank.PrintAllAccounts();
                        Console.WriteLine("Enter the account number from the above list");
                        int searchAccount = Convert.ToInt32(Console.ReadLine());
                        var AccountObject = bank.SearchAccountbyID(bank, searchAccount);
                        if (AccountObject != null)
                        {
                            Console.WriteLine("Enter the option to perform the operation(1-3): ");
                            Console.WriteLine("1.Withdraw");
                            Console.WriteLine("2.Deposit");
                            Console.WriteLine("3.view Balance");
                            int operationValue = Convert.ToInt32(Console.ReadLine());
                            switch (operationValue)
                            {
                                case 1:
                                    Console.WriteLine("Enter the amount you want to withdraw : ");
                                    int WithdrawAmount = Convert.ToInt32(Console.ReadLine());
                                    AccountObject.Withdraw(WithdrawAmount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the amount you want to deposit: ");
                                    int DepositAmount = Convert.ToInt32(Console.ReadLine());
                                    AccountObject.Deposit(DepositAmount);
                                    break;
                                case 3:
                                    AccountObject.GetBalance();
                                    break;
                                default:
                                    Console.WriteLine("Invalid operation value");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Account number is invalid/not present in the bank");
                        }
                        break;
                    case 3:
                        bank.PrintAllAccounts();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input please enter the correct option");
                        break;
                }
            }
        }

        static void DisplayOptions()
        {
            Console.WriteLine("Enter number to perform the operation : ");
            Console.WriteLine("1.Create account");
            Console.WriteLine("2.Select the bank account and perform any operation like(withdraw/deposit/getbalance)");
            Console.WriteLine("3.Display all the accounts");
            Console.WriteLine("4.Exit");
        }
        public static void AddSavingsBank(Bank bank)
        {
            IAccount SavingsAccount = new SavingsAccount();
            Console.Write("Enter Account Holder Name : ");
            string AccountHolderName = Console.ReadLine();
            Console.Write("Enter Account Number : ");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter miniumbalance that u want to deposit now : ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Account acc = new Account(SavingsAccount, AccountNumber, AccountHolderName, balance);
            bank.AddAccount(acc);
        }
        public static void AddCurrentBank(Bank bank)
        {
            IAccount CurrentAccount = new CurrentAccount();
            Console.Write("Enter Account Holder Name : ");
            string AccountHolderName = Console.ReadLine();
            Console.Write("Enter Account Number : ");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter miniumbalance that u want to deposit now : ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Account acc = new Account(CurrentAccount, AccountNumber, AccountHolderName, balance);
            bank.AddAccount(acc);
        }
    }
}
