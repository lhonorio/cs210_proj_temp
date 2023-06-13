using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("blue", 3);
        Rectangle rect = new Rectangle("red", 3, 4);
        Circle circ = new Circle("green", 2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circ);
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}\nArea: {shape.GetArea()}");
        }

        // Console.WriteLine($"Color: {square.GetColor()}\nArea: {square.GetArea()}");
        // Console.WriteLine($"Color: {rect.GetColor()}\nArea: {rect.GetArea()}");
        // Console.WriteLine($"Color: {circ.GetColor()}\nArea: {circ.GetArea()}");
    }
}