using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(10,"Green");
        Rectangle rectangle = new Rectangle(15,10, "Red");
        Circle circle = new Circle(5.5, "Blue");

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area: {shape.GetArea()} m2");
        }

    }
}