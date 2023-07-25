using BetahnyPieShopClassess.HumanResources;

namespace BetahnyPieShopClassess.Tests.HumanResources
{
    public class StoreManagerTests
    {
        [Fact]
        public void ReceiveWage_ReturnsZero_NumberOfHoursWorkedIsZero()
        {
            //arrange

            StoreManager researcher = new StoreManager(1, "Mary", "Black", "maryblack@snowball.be", new DateTime(1965, 1, 14), 15.0);
            researcher.NumberOfHoursWorked = 0;
            
            //act
            double actualWage = researcher.ReceiveWage();

            //assert
            Assert.Equal(0, actualWage);
        }




    }
}