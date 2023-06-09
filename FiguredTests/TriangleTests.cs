using FiguresLibrary.Primitives;

namespace FiguredTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1d, 1d, 1d)]
        [InlineData(1d, -1d, 1d)]
        [InlineData(1d, 1d, -1d)]
        [InlineData(0d, 0d, 0d)]
        [InlineData(1d, 1d, 4d)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void GetTriangleSidesTest()
        {
            double a = 1d, b = 2d, c = 3d;
            var triangle = new Triangle(a, b, c);

            Assert.Equal(triangle.Sides, new double[3] { a, b, c });
        }

        [Theory]
        [InlineData(1d, 1d, 1d)]
        [InlineData(1d, 1d, 1E-8)]
        [InlineData(1E-8, 1E-8, 1E-8)]
        public void InitTriangleTest(double a, double b, double c)
        {
            Assert.NotNull(() => new Triangle(a, b, c));
        }

        [Fact]
        public void GetSquareTest()
        {
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            var square = triangle.GetSquare();

            Assert.Equal(square, result);
        }


        [Theory]
        [InlineData(3d, 4d, 3d)]
        [InlineData(3d, 4d, 5d + 1e-8)]
        public void NotRightTriangleTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.False(triangle.IsRight());
        }

        [Theory]
        [InlineData(3d, 4d, 5d)]
        public void RightTriangleTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.True(triangle.IsRight());
        }
    }
}