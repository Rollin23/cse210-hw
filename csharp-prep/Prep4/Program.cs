using System;

class Program
{
    static void Main(string[] args)
    {
        // using System.Collections.Generic;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
        List<int> numbers = new List<int>();
        string input = "";
        do
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();

            int number = int.Parse(input);
            
            if (number != 0)
            {
            numbers.Add(number);    
            }

        }while (input != "0");

        int sum = numbers.Count;
        int total = numbers.Sum();
        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is {total / sum}");
        Console.WriteLine($"The largest number is {largest}");
        // Console.WriteLine($"The smallest positive number is: {smallest}");
        
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}