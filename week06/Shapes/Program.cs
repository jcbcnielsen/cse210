using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>([
            new Square("red", 5),
            new Rectangle("green", 2, 3),
            new Circle("blue", 4)
        ]);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}