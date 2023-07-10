using BetahnyPieShopClassess.HumanResources;

namespace BetahnyPieShopClassess.Tests.HumanResources
{
    public class ManagerTests
    {
        [Fact]
        public void GiveBonus_ShouldPrintCorrectBonusAmount()
        {
            //arrange
            
            Manager manager = new Manager(12345, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 14), 30);
            manager.FirstName = "Mary";
            manager.LastName = "Jones";
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            manager.GiveBonus();
            var output= stringWriter.ToString();

            //assert
            string expectedOutput = "Manager Mary Jones  received a generic bonus of 250!\r\n";
            string actualOutput = stringWriter.ToString();
            Assert.Equal(expectedOutput, output);
        }




    }
}
