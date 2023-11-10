using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 2);
        Rectangle rectangle = new Rectangle("blue", 2, 4);
        Circle circle = new Circle("yellow", 3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine();
            Console.Write("- Your shape is ");
            Console.Write(shape.GetColor());
            Console.Write(" and it's area is ");
            Console.Write(shape.GetArea());
        }
    }
}