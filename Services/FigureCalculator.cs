using SquareCalc.Interfaces;

namespace SquareCalc.Services
{
    public class FigureCalculator
    {
        public static double CalculateArea(IFigure figure)
        {
            return figure.CalculateArea();
        }
    }
}
