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
           

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);


            //Act
            employee.StopWorking();
            var output = stringWriter.ToString();


            //assert

            Assert.Equal($"Artur Nowak has stop working!\r\n", output);



        }
        [Fact]
        public void ReceiveWage_CheckReceiveWageAmount_WageAmount()
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
        
            Employee.taxRate = 10;

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);


            //Act
            employee.DisplayEmployeeDetails();
            var output = stringWriter.ToString();


            //assert

            Assert.Equal($"First name: Artur\nLast name: Nowak\nEmail: " +
                $"bartek@nowak.pl\nBirthday: 20/12/2002\n" +
                $"TaxRate: 10\r\n", output);
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

            Assert.Equal($"The current tax rate is 15\r\n", output);
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

            Assert.Equal($"You've done a great job, Artur\r\n", output);

        }





        [Fact]
        public void GiveBonus_CheckCorrectString_CorrectString()
        {
            //arrange
            Employee employee = new Employee(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 10);
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            employee.GiveBonus();
            var output = stringWriter.ToString();

            //assert

            Assert.Equal($"Artur Nowak received a generic bonus of 100!\r\n", output);
        }

        [Fact]
        public void GetEmployeeData_ReturnsFirstName_FirstName()
        {
            //Arrange
            Employee employee = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);

            //Act
            string firstName = employee.GetEmployeeData(e => e.FirstName);
            //Assert
            Assert.Equal("John", firstName);
        }

        [Fact]
        public void GetEmployeeData_ReturnsEmail_Email()
        {
            //Arrange
            Employee employee = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);

            //Act
            string email = employee.GetEmployeeData<string>(e => e.Email);
            //Assert
            Assert.Equal("john@snowball.be", email);
        }

        [Fact]
        public void GetEmployeeData_ReturnsHourlyRate_HourlyRate()
        {
            //Arrange
            Employee employee = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);

            //Act
            double hourlyRate = employee.GetEmployeeData(e => e.HourlyRate ?? 0);
            //Assert
            Assert.Equal(15.0, hourlyRate);
        }

        [Fact]
        public void CompareTo_ReturnsPositive_IdIsGreater()
        {
            //Arrange
            Employee employee1 = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);
            Employee employee2 = new Employee(2, "Jane", "Jane", "Jane@snowball.be", new DateTime(1934, 2, 3), 15.0);
            //Act
            int result = employee1.Id - employee2.Id;
            //Assert
            Assert.True(result < 0);
        }
        [Fact]
        public void CompareTo_ReturnsNegative_IdIsLess()
        {
            //Arrange
            Employee employee1 = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);
            Employee employee2 = new Employee(2, "Jane", "Jane", "Jane@snowball.be", new DateTime(1934, 2, 3), 15.0);
            //Act
            int result = employee2.CompareTo(employee1);
            //Assert
            Assert.True(result > 0);
        }

        [Fact]
        public void CompareTo_ReturnsNegative_IdEqualMinusOne()
        {
            //Arrange
            Employee employee1 = new Employee(1, "John", "John", "john@snowball.be", new DateTime(1932, 2, 3), 15.0);
            Employee employee2 = new Employee(2, "Jane", "Jane", "Jane@snowball.be", new DateTime(1934, 2, 3), 15.0);
            //Act
            int result = employee1.CompareTo(employee2);
            //Assert
            Assert.True(result == -1);
        }
       










    }
}
