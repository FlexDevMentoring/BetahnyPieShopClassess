using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetahnyPieShopClassess.HumanResources
{
    public class Employee
    {


        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthday;

        private EmployeeType employeeType;

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

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }

        }
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType emType, double rate)
        //po dodadaniu właściwości prywatnych zamiast publicznych pól zmianiamy, żeby z nich korzystać zmieniłem nazwy na wielką literę
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            EmployeeType = emType;
            HourlyRate = rate;
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType emType) : this(first, last, em, bd, emType, 0)
        {
        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stop working!");
        }

        public double ReceiveWage(int hoursWorked)
        {
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"The Wage for {NumberOfHoursWorked} hours of work is {Wage}.");
            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {Birthday.ToShortDateString()}\nEmployee type: {EmployeeType}\n");
        }
    }
}
