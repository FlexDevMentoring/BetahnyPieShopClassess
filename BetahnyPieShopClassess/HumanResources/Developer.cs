using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BetahnyPieShopClassess.HumanResources
{
    public class Developer : Employee
    {
        public Developer(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {

        }
        public double ReceiveWage()
        {
            try
            {
                double wageBeforeTax = NumberOfHoursWorked * 2 * HourlyRate.Value;
                if (HourlyRate.Value == 0)
                {
                    throw new DivideByZeroException("HourlyRate cannot be zero");
                }



                double taxAmount = wageBeforeTax * taxRate;

                Wage = wageBeforeTax - taxAmount;

                Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");
                NumberOfHoursWorked = 0;

                return Wage;
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"An error occurred while calculating the wage: {ex.Message}");
                throw;

            }
        }
            
    }

    
}
