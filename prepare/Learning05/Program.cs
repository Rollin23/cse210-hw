using System;
class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(2);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1, 9);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(8, 5);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Random random= new Random();
        Fraction f5 = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(3, 10);
            int bottomValue = random.Next(12, 8);
            f5.SetTop(topValue);
            f5.SetBottom(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString()}");
            Console.WriteLine($" Number: {f5.GetDecimalValue()}");
        }
    }
}    