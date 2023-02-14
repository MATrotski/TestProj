// See https://aka.ms/new-console-template for more information

using ShapesTest.Figures;

var figures = new List<Shape>();
figures.Add(new Circle(5));
figures.Add(new Triangle(5, 5, 8.3));

Triangle triangle = new Triangle(3, 4, 5);

foreach (var f in figures)
    Console.WriteLine($"{f.Name} square: {f.GetArea()}");

var isRightTriangle = triangle.IsRightTriangle() ? "" : "not ";
    Console.WriteLine($"This triangle is {isRightTriangle}right");