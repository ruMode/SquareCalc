using SquareCalc.Figures;
using SquareCalc.Services;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);

            double area = FigureCalculator.CalculateArea(circle);

            Assert.Equal(Math.PI * 5 * 5, area);
        }

        [Fact]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double area = FigureCalculator.CalculateArea(triangle);
            double semiP = (3 + 4 + 5) / 2;
            Assert.Equal(Math.Sqrt(semiP * (semiP - 3) * (semiP - 4) * (semiP - 5)), area);
        }

        [Fact]
        public void TestTriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRight = triangle.IsRightTriangle();

            Assert.True(isRight);
        }

        [Fact]
        public void TestRectangleArea()
        {
            Rectangle rectangle = new Rectangle(3, 5);

            double area = FigureCalculator.CalculateArea(rectangle);

            Assert.Equal(3 * 5.0, area);
        }
    }
}
