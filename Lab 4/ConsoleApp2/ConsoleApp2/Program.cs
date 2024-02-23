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
            // a)	Create an instance of the "Employee" class, representing an employee with an ID of 101, full name "John Doe," and a salary of 50000.
            Employee employee = new Employee(101, "John Doe", 50000);

            Console.WriteLine();
            // b)	Access and display the employee ID using the read-only property.
            Console.WriteLine($"Employee ID: { employee.employeeID}");

            Console.WriteLine();
            // c)	Update the full name of the employee using the read-write property.
            Console.WriteLine("Changing name from John to Joe");
            employee.FullName = "Joe Doe";
            Console.WriteLine();
            Console.WriteLine($"Employee Name: { employee.FullName}");

            Console.WriteLine();
            // d)	Attempt to modify the salary directly from external code (outside the class). Observe and comment on the result.
            // employee.salary = 10000;
            // Gives an error saying salary isn't inside employee since we have made it private it shows that error

            employee.DisplayEmployeeInfo();

        }
    }
    class Employee
    {
        public int employeeID;
        public string FullName;
        private double Salary;

        public int empID
        {
            get
            {
                return employeeID;
            }
            private set
            {
                employeeID = value; 
            }
        }

        public string empFullName
        {
            get
            {
                return FullName;
            }
            set
            {
                FullName = value;
            }
        }


        public Employee(int employeeID, string FullName, double Salary)
        {
            this.empID = employeeID;
            this.empFullName = FullName;
            this.Salary = Salary;
        }

        public double getSalary()
        {
            return Salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Details of employee\n");
            Console.WriteLine($"Employee Name: {FullName}");
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Emplyee Saary: {getSalary()}");
        }

    }
}
