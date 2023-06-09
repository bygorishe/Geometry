namespace FiguresLibrary.Primitives
{
    public class Circle : IFigure
    {
        private readonly double r;

        public double Radius { get => r; }

        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentException("Provided radius is not a positive double");

            this.r = r;
        }

        public double GetSquare()
            => r * r * Math.PI;
    }
}
