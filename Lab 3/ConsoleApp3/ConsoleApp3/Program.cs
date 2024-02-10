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
            TemperatureTracker week1 = new TemperatureTracker();

            week1.storeTemp();
            Console.WriteLine();
            week1.weekReport();
        }
    }

    class TemperatureTracker
    {
        public double[] temperatureArray = new double[7];
        

        public void storeTemp()
        {
            Console.WriteLine("Enter the values of the temperature for this week");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter Temperature of day " + (i+1) + ": ");
                temperatureArray[i] = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("Successfully stored data!");

        }

        public void weekReport()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i+1}: {temperatureArray[i]} degrees Celsius");

                
            }
            Console.WriteLine();

        }

    }
}
