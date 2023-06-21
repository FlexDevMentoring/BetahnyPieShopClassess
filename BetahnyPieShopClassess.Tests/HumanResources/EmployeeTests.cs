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
            Assert.Equal(1, employee.NumberOfHoursWorked); //sprawdzi� czy jest jedynka 
            Assert.True(employee.NumberOfHoursWorked > 0); //czy jest wi�ksze od 0 
            Assert.True(employee.NumberOfHoursWorked > hours);
            Assert.NotNull(employee);
            Assert.False(employee.NumberOfHoursWorked < hours);
            Assert.IsType<Employee>(employee);

            //mo�e by� inny test 8 razy sprawdzi�
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
        //drugi tandomowy tekstkhjghjg
        //jeszcze jeden tekst

    }
}