using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
        Rectangle rectangle = new Rectangle("blue", 4, 2);
        Circle circle = new Circle("green", 9);

        List<Shape> shapes = new List<Shape>(3);
        shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}