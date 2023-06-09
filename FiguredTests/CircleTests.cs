using FiguresLibrary.Primitives;

namespace FiguredTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-1d)]
        [InlineData(-1E-8)]
        public void InitCircleWithWrongRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(0d)] //it's a point
        [InlineData(0.5d)]
        [InlineData(1d)]
        [InlineData(1E-7)]
        [InlineData(double.MaxValue)]
        public void InitCircleRadiusTest(double radius)
        {
            Assert.NotNull(() => new Circle(radius));
        }

        [Fact]
        public void GetRaduisTest()
        {
            double radius = 13.37;
            var circle = new Circle(radius);

            Assert.Equal(radius, circle.Radius);
        }

        [Fact]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * radius * radius;

            var square = circle.GetSquare();

            Assert.Equal(square, expectedValue);
        }
    }
}