using static System.Math;

namespace FiguresLibrary.Primitives
{
    public class Triangle : IFigure
    {
        private readonly double[] _sides = null!;

        public double[] Sides { get => (double[])_sides.Clone(); }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("One or more rovided sides' lengths is not a positive double");
            else if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
                throw new ArgumentException("Provided sides do not form a triangle");

            _sides = new double[3] { side1, side2, side3 };
        }

        public double GetSquare()
        {
            var halfP = (_sides[0] + _sides[1] + _sides[2]) / 2;
            return Sqrt(halfP * (halfP - _sides[0]) * (halfP - _sides[1]) * (halfP - _sides[2]));
        }

        public bool IsRight()
        {
            Array.Sort(_sides);
            return Abs(_sides[0] * _sides[0] + _sides[1] * _sides[1] - _sides[2] * _sides[2]) <= 0;
        }
    }
}
