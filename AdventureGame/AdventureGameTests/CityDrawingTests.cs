using AdventureGame.Draw;
using Xunit;

namespace AdventureGameTests
{
    public class CityDrawingTests
    {

        private readonly CityDrawing _sut = new();

        [Theory]
        [InlineData(null,null)]
        public void CityInputGetsValideted_IfNull_ThrowError(int? height, int? width)
        {
            //Acting Assert, stores if it thorws
            var ex = Assert.Throws<ArgumentNullException>(() => _sut.ValidateCitySize(height, width));
            Assert.Contains("null", ex.Message, StringComparison.OrdinalIgnoreCase);
        }

        [Theory]
        [InlineData(5, 0, false)]
        [InlineData(0, 5, false)]
        [InlineData(-1, 5, false)]
        [InlineData(null, 5, false)]
        [InlineData(-5, null, false)]
        [InlineData(5, 5, true)]
        public void CityInputGetsANumber_DrawIfValid(int? height, int? width, bool expected)
        {

            //Act
            bool result = _sut.ValidateCitySize(height, width);

            //Assert
        
                Assert.Equal(expected, result);
        }

    }
}
