using AdventureGame.Models;
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
        [InlineData(2, true)]
        [InlineData(1, true)]
        [InlineData(50, false)]
        public void UserInputsNumber_ReturnsExcpectedRaceChoice_IfValid(int? inputNumber, bool valid)
        {
            //a
            var sut = new AdventureGame.Models.EntityCollection();
            AdventureGame.Models.ClassType pickedRace = new AdventureGame.Models.ClassType();
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
        [Theory]
        [InlineData(null, EntityCollection.ClassEnum.Invalid)]
        [InlineData(2, EntityCollection.ClassEnum.Wizard)]
        [InlineData(3, EntityCollection.ClassEnum.Theif)]
        [InlineData(4, EntityCollection.ClassEnum.Robot)]
        [InlineData(1, EntityCollection.ClassEnum.Warrior)]
        [InlineData(50, EntityCollection.ClassEnum.Invalid)]
        public void UserInputsNumber_ReturnsExcpectedRaceEnum_IfValid(int? inputNumber, EntityCollection.ClassEnum race)
        {
            //a
            var sut = new AdventureGame.Models.EntityCollection();
            AdventureGame.Models.ClassType pickedRace = new AdventureGame.Models.ClassType();
            //a
            var result = sut.GetRaceEnum(inputNumber);

            //a
            Assert.Equal(race, result);
        }
    }
}







