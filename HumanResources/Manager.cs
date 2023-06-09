﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class Manager : Employee, IManager
    {
        public Manager(int id, string first, string last, string em, DateTime bd, double? rate):base(id, first, last, em, bd, rate)
        { 
        }

        public void AttendMangementMeeting()
        {
            NumberOfHoursWorked += 10;


            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"Manager {FirstName} {LastName} received a generic bonus of 500!");
            else
                Console.WriteLine($"Manager {FirstName} {LastName}  received a generic bonus of 250!");
        }

        public double ReceiveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * 2 * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }
    }
}
