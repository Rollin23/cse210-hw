using System;

class Program
{
    static void Main(string[] args)
    {
        // //for each loop
        // List<string> words = new List<string>();
        // words.Add("cold");
        // words.Add("snow");
        // words.add("soccer");
        // foreach (string word in words)
        // {
        //     Console.WriteLine("word");
        // }

        //for loop
        // for(int i = 0; i < 10;)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }

        // for(int i = 10; i > 0;)
        // {
        // Console.WriteLine(i);
        // i--;
        // }

              //for each loop
        // List<string> words = new List<string>();
        // words.Add("cold");
        // words.Add("snow");
        // words.Add("soccer");
        // for (int i = words.Count - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(words[i]);
        // }

        // void DisplayMessage(string name)
        // {
        //     Console.WriteLine($"Hello {name}");
        // }

        // DisplayMessage("World");
        // DisplayMessage("Class");

        // for (int i = 0; i < 5; i++)
        // {
        // Console.WriteLine("Hello, world!");    
        // }

        //         //for loop
        // for(int i = 1; i < 50; i += 2)
        // {
        //     Console.Write(i);
        //     i++;
        // }
        // Console.Write("Input a word ");
        // string inputs = Console.ReadLine();
        // List<char> words = new List<char>();

        // foreach (char letter in inputs)
        // {
        //     words.Add(letter);

        // }
        // for (int i = words.Count -1; i >= 0; i--)
        // {
        //     Console.Write(words[i]);
        // }

                // using System.Collections.Generic;
        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
        // List<int> numbers = new List<int>();
        // string input = "";
        // do
        // {
        //     Console.Write("Enter number: ");
        //     input = Console.ReadLine();

        //     int number = int.Parse(input);
            
        //     if (number != 0)
        //     {
        //     numbers.Add(number);    
        //     }

        // }while (input != "0");

        // int sum = numbers.Count;
        // int total = numbers.Sum();
        // int largest = numbers[0];
        // int smallest = numbers[0];

        // foreach (int number in numbers)
        // {
        //     if (number < smallest)
        //     {
        //         smallest = number;
        //     }
        // }
        // Console.WriteLine($"The sum is: {total}");
        // Console.WriteLine($"The average is {total / sum}");
        // Console.WriteLine($"The largest number is {largest}");
        // // Console.WriteLine($"The smallest positive number is: {smallest}");
        
        // numbers.Sort();
        // for (int i = 0; i < numbers.Count; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }

        
        Message m1 = new Message();
        m1._message ="Send help!";
        m1._priority = 1;

        Console.WriteLine(m1.GetMessage());

        Message m2 = new Message();
        m2._message= "I need redBull";
        m2._priority = 3;


    }
}