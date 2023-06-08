﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class Manager : Employee
    {
        public Manager(string first, string last, string em, DateTime bd, double? rate):base(first, last, em, bd, rate)
        { 
        }

        public void AttendMangementMeeting()
        {
            NumberOfHoursWorked += 10;

            
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email");
        }

        public override void GiveBonus()
        {
            if ( NumberOfHoursWorked > 5 )
                Console.WriteLine($"Manager {FirstName} {LastName} received a generic bonus of 500!");   
            else
                Console.WriteLine($"Manager {FirstName} {LastName}  received a generic bonus of 250!");
        }   
    }
}