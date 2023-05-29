using BetahnyPieShopClassess.HumanResources;
using System;

Console.WriteLine("Creating an employee");
Console.WriteLine("----------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);

Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1999, 2, 23), EmployeeType.Research, 30);

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

Employee.taxRate = 0.02;

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
