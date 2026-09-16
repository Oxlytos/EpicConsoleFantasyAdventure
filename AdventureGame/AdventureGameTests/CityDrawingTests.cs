using AdventureGame.Draw;
using Xunit;

namespace AdventureGameTests
{
    public class CityDrawingTests
    {


        [Theory]
        [InlineData(5, 0, false)]
        [InlineData(0, 5, false)]
        [InlineData(-1, 5, false)]
        [InlineData(null, 5, false)]
        [InlineData(-5, null, false)]
        [InlineData(5, 5, true)]
        public void CityInputGetsANumber_DrawIfValid(int? height, int? width, bool expected)
        {
            //Arrange

            var sut = new CityDrawing();

            //Act
            Assert.Throws<ArgumentNullException>(() => sut.ValidateCitySize(height, width)).Message.Contains("null");


            bool result = sut.ValidateCitySize(height, width);


            //Assert
            if (result == true)
            {
                Assert.Equal(expected, result);
            }
            else
            {



            }
        }

    }
}
