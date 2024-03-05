using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("Red", 5);
        Square square2 = new Square("Blue", 9);
        Rectangle rectangle1 = new Rectangle("Orange", 25, 15);
        Rectangle rectangle2 = new Rectangle("Liam", 21, 5);
        Circle circle = new Circle("green", 9);

        shapes.Add(square1);
        shapes.Add(square2);
        shapes.Add(rectangle1);
        shapes.Add(rectangle2);
        shapes.Add(circle);

        foreach (Shape item in shapes) 
        {
            Console.WriteLine(item.GetArea());
            Console.WriteLine(item.GetColor());
        };
 
    }
}