using System;
class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Red", 4);
        shapes.Add(square1);

        Rectangle rec1 = new Rectangle("Yellow", 3, 3);
        shapes.Add(rec1);

        Circle cir1 = new Circle("Blue", 2);
        shapes.Add(cir1);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape had an area of {area}.");
        }
    }


    
}    