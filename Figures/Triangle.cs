using SquareCalc.Interfaces;

namespace SquareCalc.Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            double a = SideA;
            double b = SideB;
            double c = SideC;

            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
