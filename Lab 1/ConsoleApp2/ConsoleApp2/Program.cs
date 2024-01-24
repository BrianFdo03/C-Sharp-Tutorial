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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number " + (i+1));
                int number = Convert.ToInt32(Console.ReadLine());

                int numberType = number % 2;

                if (numberType == 0 )
                {
                    Console.WriteLine( number + " is even\n\n");
                }
                else
                {
                    Console.WriteLine( number + " is odd\n\n");
                }
            }
        }
    }
}
