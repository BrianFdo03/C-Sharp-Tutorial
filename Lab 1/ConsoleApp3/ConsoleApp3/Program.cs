using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0 )
            {
                Console.WriteLine("Entered value is incorrect. Please enter a positive number.");
            }
            else
            {
                int total = 0;

                for (int i = 0; i <= number; i++)
                {
                    total += i;
                }

                Console.WriteLine("Total sum of the additions of all numbers upto " + number + ": " + total);
            }
            
        }
    }
}
