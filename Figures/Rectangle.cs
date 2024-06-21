using SquareCalc.Interfaces;

namespace SquareCalc.Figures
{
    public class Rectangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Rectangle(double sideA, double sideB) 
        {
            SideA = sideA; SideB = sideB;
        }
        public double CalculateArea()
        {
           return SideA * SideB / 2;
        }
    }
}
