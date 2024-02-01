using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double AccountBalance = 0;
            double DepositValue;
            double WithdrawValue;
            bool check = true;

            do
            {
                Console.WriteLine("Do you need to use ATM machine [Y/N]");
                char AtmSelection = Convert.ToChar(Console.ReadLine()) ;
                AtmSelection = char.ToUpper(AtmSelection);

                if (AtmSelection == 'Y')
                {
                    Console.WriteLine("What function would you like to use?");
                    Console.WriteLine("1. Check Bank Balance");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money \n\n");
                    Console.WriteLine("Select the number of the service you require");

                    int Service = Convert.ToInt32(Console.ReadLine()) ;

                    switch (Service)
                    {
                        case 1:
                            CheckBalance(AccountBalance);

                            break;

                        case 2:
                            Console.WriteLine("How much do you want to deposit?");
                            DepositValue = Convert.ToDouble(Console.ReadLine());
                            DepositMoney(AccountBalance, DepositValue);
                            AccountBalance += DepositValue;
                            CheckBalance(AccountBalance);

                            break;

                        case 3:
                            Console.WriteLine("How much do you want to withdraw?");
                            WithdrawValue = Convert.ToDouble(Console.ReadLine());
                            WithdrawMoney(AccountBalance);
                            AccountBalance -= WithdrawValue;
                            CheckBalance(AccountBalance);

                            break;

                        default:
                            Console.WriteLine("Your selection wrong.\n\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for banking with us");
                    break;
                }
                
            } while (check == true );
            
        }

        static void CheckBalance(double AccountBalance)
        {
            Console.WriteLine("Your bank balance is Rs." + AccountBalance + "\n\n");
        }

        static void DepositMoney(double AccountBalance, double DepositValue)
        {
            
            Console.WriteLine("Please wait. Transaction processing");

            AccountBalance += DepositValue;
            Console.WriteLine("You have Successfully deposited money\n\n");
        }

        static void WithdrawMoney(double AccountBalance)
        {
            

            Console.WriteLine("Please wait. Transaction processing");
            
            Console.WriteLine("Here is the requested value\n\n");


        }
    }

}
