using BetahnyPieShopClassess.HumanResources;

namespace BetahnyPieShopClassess.Tests.HumanResources
{
    public class ReasercherTests
    {
        [Fact]
        public void ResearcherNewPieTastes_IncrementsNumberOfHoursWorked()
        {
            //arrange

            Researcher researcher = new Researcher(1, "Mary", "Black", "maryblack@snowball.be", new DateTime(1965, 1, 14), 15.0);
            int researchHours = 5;
            int initialNumberOfHoursWorked = researcher.NumberOfHoursWorked;

            //act
            researcher.ResearchNewPieTastes(researchHours);
            int updateNumberOfHoursWorked = researcher.NumberOfHoursWorked;

            //assert
            Assert.Equal(initialNumberOfHoursWorked + researchHours, updateNumberOfHoursWorked);
        }

        [Fact]
        public void ReceiveWage_CalculatesWageCorrectly_CorrectWage()
        {
            //arrange

            Researcher researcher = new Researcher(1, "Mary", "Black", "maryblack@snowball.be", new DateTime(1965, 1, 14), 15.0);
            researcher.NumberOfHoursWorked = 40;
            double expectedWage = 40 * 2 * 15 * (1 - Employee.taxRate);

            //act
            double actualWage = researcher.ReceiveWage();

            //assert
            Assert.Equal(expectedWage, actualWage);
            Assert.Equal(0, researcher.NumberOfHoursWorked);
        }




    }
}