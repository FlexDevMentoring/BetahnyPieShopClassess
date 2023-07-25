using BetahnyPieShopClassess.HumanResources;

namespace BetahnyPieShopClassess.Tests.HumanResources
{
    public class ManagerTests
    {
        [Fact]
        public void GiveBonus_ShouldPrintCorrectString_CorrectString()
        {
            //arrange
            
            Manager manager = new Manager(12345, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 14), 30);
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            manager.GiveBonus();
            var output = stringWriter.ToString();
            
            //assert
            Assert.Equal($"Manager Mary Jones  received a generic bonus of 250!\r\n", output);
        }




    }
}
