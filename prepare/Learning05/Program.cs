using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 3);
        shapes.Add(square1);

        Rectangle rect1 = new Rectangle("Blue", 4, 5);
        shapes.Add(rect1);

        Circle circle1 = new Circle("Green", 6);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = Math.Round(shape.GetArea(),2);
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}