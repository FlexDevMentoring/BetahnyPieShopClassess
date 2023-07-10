using BetahnyPieShopClassess.HumanResources;

namespace BetahnyPieShopClassess.Test.HumanResources
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_CheckNumberOfHoursWorkedChenges_AddedHours()
        {
            //arrange

            Employee employee = new Employee(1, "Bartek", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);
            int hours = employee.NumberOfHoursWorked;

            //Act
            employee.PerformWork();

            //assert
            Assert.NotEqual(employee.NumberOfHoursWorked, hours);
            Assert.Equal(1, employee.NumberOfHoursWorked);
            Assert.True(employee.NumberOfHoursWorked > 0);
            Assert.True(employee.NumberOfHoursWorked > hours);
            Assert.NotNull(employee);
            Assert.False(employee.NumberOfHoursWorked < hours);
            Assert.IsType<Employee>(employee);


        }

        [Fact]

        public void PerformWork_HowManyTimesNumberOfHoursWorkedPerform_AddedHours()
        {
            //arrange

            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);

            //Act

            for (int hours = employee.NumberOfHoursWorked; hours < 8; hours++)
            { employee.NumberOfHoursWorked++; }

            //assert
            Assert.Equal(8, employee.NumberOfHoursWorked);
        }

        [Fact]

        public void StopWorking_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);  //czy muszê w testach tworzyæ innego pracownika?
            employee.FirstName = "Artur";
            employee.LastName = "Nowak";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);


            //Act
            employee.StopWorking();
            var output = stringWriter.ToString();


            //assert

            Assert.Equal($"{"Artur"} {"Nowak"} has stop working!\r\n", output);



        }
        [Fact]
        public void ReceiveWage_CheckREceiveWageAmount_WageAmount()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);

            employee.ReceiveWage();
            double wageBeforeTax = (double)(employee.NumberOfHoursWorked * 2 * employee?.HourlyRate);
            double taxAmount = wageBeforeTax * Employee.taxRate;
            double expectedWage = wageBeforeTax - taxAmount;

            //act
            var actualWage = employee.ReceiveWage();

            //assert
            Assert.Equal(expectedWage, actualWage);



        }

        [Fact]
        public void DisplayEmployeeDetails_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10); 
            employee.FirstName = "Artur";
            employee.LastName = "Nowak";
            employee.Email = "bartek@nowak.pl";
            employee.Birthday = new DateTime(2002, 12, 20);
            Employee.taxRate = 10;

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);


            //Act
            employee.DisplayEmployeeDetails();
            var output = stringWriter.ToString();


            //assert

            Assert.Equal($"First name: {"Artur"}\nLast name: {"Nowak"}\nEmail: " +
                $"{"bartek@nowak.pl"}\nBirthday: {"20/12/2002"}\n" +
                $"TaxRate: {10}\r\n", output);
        }

        [Fact]

        public void DisplayTaxRate_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10); 
            
            Employee.taxRate = 15;
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            Employee.DisplayTaxRate();
            var output = stringWriter.ToString();

            //assert

            Assert.Equal($"The current tax rate is {15}\r\n", output);
        }

        [Fact]
        public void GiveCompliment_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);

            employee.FirstName = "Artur";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            employee.GiveCompliment();
            var output = stringWriter.ToString();

            //assert

            Assert.Equal($"You've done a great job, {"Artur"}\r\n", output);

        }





        [Fact]
        public void GiveBonus_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);
            employee.FirstName = "Artur";
            employee.LastName = "Nowak";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            employee.GiveBonus();
            var output = stringWriter.ToString();

            //assert

            Assert.Equal($"{"Artur"}{"Nowak"} received a generic bonus of 100!\r\n", output);
        }





    }
}
