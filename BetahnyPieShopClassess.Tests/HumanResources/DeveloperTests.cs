using BetahnyPieShopClassess.HumanResources;
using System.Security.Cryptography.X509Certificates;

namespace BetahnyPieShopClassess.Tests.HumanResources
{
    public class DeveloperTests
    {

        [Fact]
        public void ReceiveWage_ReturnsCorrectWage()
        {
            //arrange
            Developer developer = new Developer(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 15.0);

            developer.NumberOfHoursWorked = 40;
            developer.HourlyRate = 20.0;

            //act
            double wage = developer.ReceiveWage();

            //assert
            Assert.Equal(1360.0, wage);

           

        }
        [Fact]
        public void ReceiveWage_ThrowsDivideByZeroException_WhenHourlyRateIsZero()
        {
            //arrange
            Developer developer = new Developer(1, "Artur", "Nowak", "bartek@nowak.pl", new DateTime(2002, 12, 20), 0.0);
            developer.NumberOfHoursWorked = 40;
            


            //act & Assert
            Assert.Throws<DivideByZeroException>(() => developer.ReceiveWage());
        }   
    }
}
