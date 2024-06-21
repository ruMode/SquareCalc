using SquareCalc.Figures;
using SquareCalc.Services;

Console.WriteLine("Choose Figure for calculating:");
Console.WriteLine("1 for Circle\n 2 for Triangle\n  3 for Rectangle");

var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Enter circle radius:");

        var radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(radius);

        Console.WriteLine($"Square = {FigureCalculator.CalculateArea(circle)}");
        break;

    case "2":
        Console.WriteLine("Enter sides of triangle:");

        Console.WriteLine("Side A:");
        var sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Side B:");
        var sideB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Side C:");
        var sideC = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new Triangle(sideA, sideB, sideC);

        Console.WriteLine($"Square = {FigureCalculator.CalculateArea(triangle)}");

        if (triangle.IsRightTriangle()) Console.WriteLine("Triangle is Right");
        else Console.WriteLine("This is NOT Right Triangle");

        break;

    case "3":
        Console.WriteLine("Enter sides of triangle:");

        Console.WriteLine("Side A:");
        var rectSideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Side B:");
        var rectSideB = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(rectSideA, rectSideB);

        Console.WriteLine($"Square = {FigureCalculator.CalculateArea(rectangle)}");

        break;

}
