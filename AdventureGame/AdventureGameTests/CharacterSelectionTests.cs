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
        [Theory]
        [InlineData(null, EntityCollection.EntityEnum.Invalid)]
        [InlineData(2, EntityCollection.EntityEnum.Wizard)]
        [InlineData(3, EntityCollection.EntityEnum.Theif)]
        [InlineData(4, EntityCollection.EntityEnum.Robot)]
        [InlineData(1, EntityCollection.EntityEnum.Warrior)]
        [InlineData(50, EntityCollection.EntityEnum.Invalid)]
        public void UserInputsNumber_ReturnsExcpectedRaceEnum_IfValid(int? inputNumber, EntityCollection.EntityEnum race)
        {
            //a
            var sut = new AdventureGame.Models.EntityCollection();
            AdventureGame.Models.EntityRace pickedRace = new AdventureGame.Models.EntityRace();
            //a
            var result = sut.GetRaceEnum(inputNumber);

            //a
            Assert.Equal(race, result);
        }
    }
}







