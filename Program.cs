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

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            Manager mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 14), 30);

            JuniorResearcher bobJunior = new JuniorResearcher("Bob", "Spencer", "bobJunior@snowball.be", new DateTime(1988, 1, 23), 17);

            Researcher rich = new Researcher("Rich", "Spencer", "Rich@snowball.be", new DateTime(1988, 2, 12, 12, 55, 43), 12);

            StoreManager kate = new StoreManager("Kate", "Jordan", "jordannotmichael@snowball.be", new DateTime(1932, 2, 3), 12);

            //bethany.DisplayEmployeeDetails();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.ReceiveWage();

            //mary.DisplayEmployeeDetails();
            //mary.PerformWork();
            //mary.ReceiveWage();
            //mary.GiveBonus();


            //mary.AttendMangementMeeting();

            //bobJunior.ResearchNewPieTastes(10);
            //bobJunior.PerformWork();
            //bobJunior.ReceiveWage();
            //bobJunior.GiveBonus();

            //bethany.GiveBonus();
            //mary.GiveBonus();

            Employee[] employees = new Employee[] { bethany, bobJunior, rich, mary, kate };


            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
                employee.PerformWork();
                employee.ReceiveWage();
                employee.GiveBonus();
                Console.WriteLine("\n");
                //employee.AttendingMangementMeeting();
            }

            Console.ReadLine();
        }
    }
}