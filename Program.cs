using BetahnyPieShopClassess.HumanResources;
using System;

namespace BetahnyPieShopClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("----------------");

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10000000; i++)
            {
                Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), EmployeeType.StoreMenager, null);
                employees.Add(randomEmployee);

            }

            employees.Clear();
            employees = null;
            GC.Collect();

            Console.ReadLine();

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);

            Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1999, 2, 23), EmployeeType.Research, 30);

            //Employee mysteryPerson;// = null;
            //mysteryPerson.DisplayEmployeeDetails();

            bethany.HourlyRate = 50;
            bethany.NumberOfHoursWorked = 100;
            bethany.Wage = -10;


            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            Console.WriteLine("\nCreating next employee");


            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();


            Employee.taxRate = 0.02; //change taxRate on 0.02 and so... new Wage

            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            Console.WriteLine("\nCreating next employee");


            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();

            Console.ReadLine();
        }
    }
}