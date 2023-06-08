using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }


        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            Console.WriteLine($"Researcher {FirstName}{LastName} has invented a new pie taste!");
        }
    }

    

}
