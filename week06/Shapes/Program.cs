using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of shapes
        Square square = new Square(4, "Red");
        Circle circle = new Circle(5, "Blue");
        Rectangle rectangle = new Rectangle(3, 6, "Green");

        // Testing each shape individually
        Console.WriteLine("Individual shape tests:");
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Creating a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        // Iterating through the list and displaying color and area
        Console.WriteLine("\nIterating through the list of shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}