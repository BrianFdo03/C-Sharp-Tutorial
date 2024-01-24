using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Id");
            string stdId = Console.ReadLine();

            Console.WriteLine("Enter mark");
            int mark = Convert.ToInt32( Console.ReadLine());

            if (mark > 100 || mark < 0)
            {
                Console.WriteLine("Incorrect mark. Please enter again");
            }
            else if (mark <= 75)
            {
                Console.WriteLine(stdId + " has A grade");
            }
            else if (mark < 60)
            {
                Console.WriteLine(stdId + " has B grade");
            }
            else if (mark < 50)
            {
                Console.WriteLine(stdId + " has C grade");
            }
            else if (mark < 40)
            {
                Console.WriteLine(stdId + " has D grade");
            }
            else
            {
                Console.WriteLine(stdId + " has failed!!");
            }
        }
    }
}
