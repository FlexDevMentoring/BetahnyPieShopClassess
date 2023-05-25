using BetahnyPieShopClassess.HumanResources;
using System;

Console.WriteLine("Creating an employee");
Console.WriteLine("----------------");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);

Employee george = new Employee("George", "Smith", "george@snowball.be", new DateTime(1999, 2, 23), EmployeeType.Research, 30);

bethany.HourlyRate = 50;
bethany.NumberOfHoursWorked = 100;
bethany.Wage = -10;

bethany.DisplayEmployeeDetails();
bethany.PerformWork(2);
bethany.PerformWork(3);
bethany.ReceiveWage(4);

Console.WriteLine("\nCreating next employee");

george.DisplayEmployeeDetails();
george.PerformWork(4);
george.PerformWork(5);
george.PerformWork(6);
george.ReceiveWage(7);


Console.ReadLine();
