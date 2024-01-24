using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine()) ;

            if (number <= 0 )
            {
                Console.WriteLine("Please enter a positive number ");
            }
            else
            {
                int ans;

                for (int i = 1; i <= number; i++)
                {
                    ans = i * number;
                    Console.WriteLine(i + " X " + number + " = " + ans);
                }
            }

            
        }
    }
}
