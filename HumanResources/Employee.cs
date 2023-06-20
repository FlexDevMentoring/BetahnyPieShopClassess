using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public abstract class Employee
    {


        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRate;
        private DateTime birthday;


        public static double taxRate = 0.15;
        private const double maxAmountHoursWOrked = 1000; //beacouse I can put the value later I must define const variable  s here

        public string FirstName  //it is Properties
        {
            get //kod zwracający wartość pola które opakowuje czyli pole (rzeczywiste dane)
            {
                return firstName;
            }
            set // wartość i opcjonalnie kod aby sprawdzić czy dane są poprawne
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            set { numberOfHoursWorked = value; }
        }
        public double Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }

        }

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        //po dodadaniu właściwości prywatnych zamiast publicznych pól zmianiamy, żeby z nich korzystać zmieniłem nazwy na wielką literę
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;

            HourlyRate = rate ?? 10; //I use default value if value if null is past in (I use no coalescenci operator" 
        }                            //If value is null use value on the right side of the question mark

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stop working!");
        }

        public abstract double ReceiveWage();


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nEmail: " +
                $"{Email}\nBirthday: {Birthday.ToShortDateString()}\n" +
                $"TaxRate: {taxRate}");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName}{LastName} received a generic bonus of 100!");
        }
    }
}
