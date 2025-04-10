using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Testing individual shapes
        Square square = new Square("red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        // Creating a list of shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterating the list
        Console.WriteLine("\nIterating through list of shapes:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}