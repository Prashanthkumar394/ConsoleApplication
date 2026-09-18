using System;

namespace Task18
{
    class Account
    {
        int accountNumber;
        string accountHolder;
        int balance;
        public Account(int accountNumber, string accountHolder, int balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Amount deposited");
        }
        public void Deposit(int amount, bool val)
        {
            balance += amount;
            Console.WriteLine("Amount deposited\n");
            Console.Write("Receipt: Amount deposited - "+amount+"\n         Total balance - "+balance);
        }
        public void WithDraw()
        {
            Console.Write("\nEnter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(amount<balance)
            {
                balance -= amount;
                Console.WriteLine("Amount dispensed...");
            }
            else
                Console.WriteLine("Insufficient balance...");
        }
        public void WithDraw(bool val)
        {
            Console.Write("\nEnter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if(amount<balance)
            {
                balance -= amount;
                Console.WriteLine("Amount dispensed...");
                Console.Write("Receipt: Amount deposited - "+amount+"\n         Total balance - "+balance);
            }
            else
                Console.WriteLine("Insufficient balance...");
        }
        public void Balance()
        {
            Console.WriteLine(balance);
        }
    }
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNumber, string accountHolder, int balance) 
            : base(accountNumber, accountHolder, balance)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool MFlag = true;
            while(MFlag)
            {
                Console.Write("1. Current Account\n2. Savings Account\n3. Exit Application\nChoose an option: ");
                String option = Console.ReadLine();
                
                switch(option)
                {
                    case "1":
                        bool CFlag = true;
                        while(CFlag)
                        {
                            Console.Write("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. Cancel\nChoose an option: ");
                            String COption = Console.ReadLine();
                            Console.WriteLine();
                            Account account = new Account(2000107839, "vinith", 1000);
                            switch(COption)
                            {
                                case "1":
                                    bool CDFlag = true;
                                    while(CDFlag)
                                    {
                                        Console.Write("Do you want receipt\n1. Yes\n2. No\n3. Cancel\nChoose an option: ");
                                        string SWOption = Console.ReadLine();
                                        Console.WriteLine();
                                        switch(SWOption)
                                        {
                                            case "1":
                                                Console.Write("Enter the amount: ");
                                                int amount = Convert.ToInt32(Console.ReadLine());
                                                account.Deposit(amount, true);
                                                break;
                                            case "2":
                                                Console.Write("Enter the amount: ");
                                                amount = Convert.ToInt32(Console.ReadLine());
                                                account.Deposit(amount);
                                                break;
                                            case "3":
                                                CDFlag = false;
                                                CFlag = false;
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    Console.Write("Do you want receipt\n1. Yes\n2. No\n3. Cancel\nChoose an option: ");
                                    string SWOption = Console.ReadLine();
                                    Console.WriteLine();
                                    switch(SWOption)
                                    {
                                        case "1":
                                            account.WithDraw(true);
                                            CFlag = false;
                                            break;
                                        case "2":
                                            account.WithDraw();
                                            CFlag = false;
                                            break;
                                    }
                                    break;
                                case "3":
                                    account.Balance();
                                    break;
                                case "4":
                                    CFlag = false;
                                    break;
                            }
                        }
                        break;
                    case "2":
                        CFlag = true;
                        while(CFlag)
                        {
                            Console.Write("\n1. Deposit\n2. Withdraw\n3. View Balance\n4. View Interest rate\n5. Cancel\nChoose an option: ");
                            String COption = Console.ReadLine();
                            Console.WriteLine();
                            SavingsAccount sAccount = new SavingsAccount();
                            switch(COption)
                            {
                                case "1":
                                    bool CDFlag = true;
                                    while(CDFlag)
                                    {
                                        Console.Write("\nDo you want receipt\n1. Yes\n2. No\n3. Cancel\nChoose an option: ");
                                        string SWOption = Console.ReadLine();
                                        switch(SWOption)
                                        {
                                            case "1":
                                                Console.Write("\nEnter the amount: ");
                                                int amount = Convert.ToInt32(Console.ReadLine());
                                                sAccount.Deposit(amount, true);
                                                break;
                                            case "2":
                                                Console.Write("\nEnter the amount: ");
                                                amount = Convert.ToInt32(Console.ReadLine());
                                                sAccount.Deposit(amount);
                                                break;
                                            case "3":
                                                CDFlag = false;
                                                CFlag = false;
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    CDFlag = true;
                                    while(CDFlag)
                                    {
                                        Console.Write("\nDo you want receipt\n1. Yes\n2. No\n3. Cancel\nChoose an option: ");
                                        string SWOption = Console.ReadLine();
                                        switch(SWOption)
                                        {
                                            case "1":
                                                Console.Write("\nEnter the amount: ");
                                                int amount = Convert.ToInt32(Console.ReadLine());
                                                sAccount.WithDraw(amount, true);
                                                break;
                                            case "2":
                                                Console.Write("\nEnter the amount: ");
                                                amount = Convert.ToInt32(Console.ReadLine());
                                                sAccount.WithDraw(amount);
                                                break;
                                            case "3":
                                                CDFlag = false;
                                                CFlag = false;
                                                break;
                                        }
                                    }
                                    break;
                                case "3":
                                    sAccount.Balance();
                                    break;
                                case "4":
                                    sAccount.Interest();
                                    break;
                                case "5":
                                    CFlag = false;
                                    break;
                            }
                        }
                        break;
                    case "3":
                        MFlag = false;
                        Console.Write("Exited Application...");
                        break;
                }
            }
        }
    }
}