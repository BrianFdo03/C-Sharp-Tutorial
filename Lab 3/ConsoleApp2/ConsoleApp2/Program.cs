using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountNumber;
            double bankBalance;

            Console.WriteLine("Enter your bank account number");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your current bank balance");
            bankBalance = Convert.ToDouble(Console.ReadLine());

            BankAccount bankAccount1 = new BankAccount(accountNumber, bankBalance);

            Console.WriteLine("Do you view account details? [Y/N]");
            char select = Convert.ToChar(Console.ReadLine());
            select = char.ToUpper(select);

            if (select == 'Y')
            {
                bankAccount1.accountDetails();
            }
            else
            {
                Console.WriteLine("Do you want to deposit money? [Y/N]");
                select = Convert.ToChar(Console.ReadLine());
                select = char.ToUpper(select);

                if (select == 'Y')
                {
                    bankAccount1.Deposit();
                }
                else
                {
                    Console.WriteLine("Thank you for banking with us.");
                }
            }

            
        }
    }

    class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public BankAccount(int AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            Console.WriteLine("Account created successfully!!");
            Console.WriteLine();
        }

        public void accountDetails()
        {
            Console.WriteLine("Account number: " + AccountNumber);
            Console.WriteLine("Account balance: " + Balance);
            Console.WriteLine();
        }

        public void Deposit()
        {
            Console.WriteLine("Enter amount you want to deposit");
            double depositValue = Convert.ToDouble(Console.ReadLine());
            Balance += depositValue;
            Console.WriteLine("Depossited Rs. " + depositValue);
            checkBalance();
            Console.WriteLine();
            
        }

        public void checkBalance()
        {
            Console.WriteLine("The balance of account number " + AccountNumber + " is: Rs. " + Balance);
        }
    }
}
