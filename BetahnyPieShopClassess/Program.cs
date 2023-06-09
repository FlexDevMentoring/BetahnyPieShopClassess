﻿using BetahnyPieShopClassess.HumanResources;
using System;

namespace BetahnyPieShopClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("----------------");

            Manager bethany = new Manager(55156, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            Manager mary = new Manager(12345,"Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 14), 30);


            JuniorResearcher bobJunior = new JuniorResearcher(1, "Bob", "Spencer", "bobJunior@snowball.be", new DateTime(1988, 1, 23), 17);

            Researcher rich = new Researcher(12, "Rich", "Spencer", "Rich@snowball.be", new DateTime(1988, 2, 12, 12, 55, 43), 12);

            StoreManager kate = new StoreManager(100, "Kate", "Jordan", "jordannotmichael@snowball.be", new DateTime(1932, 2, 3), 12);


            List<IEmployee> employees = new List<IEmployee>
            {
                bethany,
                mary,
                bobJunior,
                rich,
                kate
            };

            employees.Sort();

            foreach(var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }


            mary.AttendMangementMeeting();
            mary.ReceiveWage();

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

            //Employee[] employees = new Employee[] { bethany, bobJunior, rich, mary, kate };


            //foreach (var employee in employees)
            //{
            //    employee.DisplayEmployeeDetails();
            //    employee.PerformWork();
            //    employee.ReceiveWage();
            //    employee.GiveBonus();
            //    Console.WriteLine("\n");
            //    Console.WriteLine(employee.ToString());
            //    //employee.AttendingMangementMeeting();
            //}

            //object o1 = new Manager(12, "Object", "Jones", "mary@snowball.be", new DateTime(1965, 1, 14), 30);
            //o1.ToString();

            Console.ReadLine();
        }
    }
}