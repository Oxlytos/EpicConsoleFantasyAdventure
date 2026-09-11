using Xunit;

namespace AdventureGameTests
{
    public class CharacterSelectionTests
    {


        [Theory]
        [InlineData(null, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(2, false)]
        [InlineData(1, false)]
        [InlineData(50, false)]
        public void UserInputsNumber_ReturnsExcpectedRaceChoice_IfValid(int? inputNumber, bool valid)
        {
            //a
            var sut = new AdventureGame.Models.Entitylist();
            AdventureGame.Models.EntityRace pickedRace = new AdventureGame.Models.EntityRace();
            bool result;
            //a
            var race = sut.getRace(inputNumber);
            if (race != null)
            {
                result = true;
            }
            else { result = false; }


            //a
            Assert.Equal(valid, result);
        }
    }
}







