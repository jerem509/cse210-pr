using System;

class Program
{
    static void Main(string[] args)
    {
        //Circle object test
        Square newSquare = new Square(color:"yellow", side:5);
        Console.WriteLine($"Color: {newSquare.GetColor()}- Area: {newSquare.GetArea()}");
        Console.WriteLine();
 

        //Rectangle object test
        Rectangle nuRectangle = new Rectangle(width: 5, length: 4, "Red");
        Console.WriteLine($"Color: {nuRectangle.GetColor()}- Area: {nuRectangle.GetArea()}");
        Console.WriteLine();

        //Circle object
        Circle nuCircle = new Circle(radius: 4, "Blue");
        Console.WriteLine($"Color: {nuCircle.GetColor()}- Area: {nuCircle.GetArea()}");

        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(newSquare);
        shapes.Add(nuRectangle);
        shapes.Add(nuCircle);


        Console.WriteLine("Iterations :");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}- Area: {shape.GetArea()}");
        }
    }
}