using AdventureGame.Draw;
using Xunit;

namespace AdventureGameTests
{
    public class CityDrawingTests
    {

        private readonly CityDrawing _sut = new();

        [Theory]
        [InlineData(null, null)]
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


        [Theory]
        [InlineData(0)]
        [InlineData(30)]
        [InlineData(-25)]
        [InlineData(null)]
        [InlineData(10)]
        public void CityInputNumber_WithinRange_IsExcpected(int? size)
        {
            //Arrange

            //Act
            int minsize = _sut.GetMinimalSize();
            int maximalSize = _sut.GetMaximalSize();


            //Assert
            Assert.InRange(size.Value, minsize, maximalSize);

        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(30, 20)]
        [InlineData(-25, -25)]
        [InlineData(null, 20)]
        [InlineData(10, 20)]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        [InlineData(25, 25)]
        public void CityInputArea_WithinRange_IsExcpected(int? width, int? height)
        {
            //Arrange

            //Act

            int minAreaSize = _sut.GetMinimalArea();
            int maximalAreaSize = _sut.GetMaximalArea();
            int result = _sut.GetArea(width, height);

            //Assert

            Assert.InRange(result, minAreaSize, maximalAreaSize);


        }
    }
}
