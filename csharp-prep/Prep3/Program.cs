using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int correct = 0;
        string answer = "";

        do
        {
            int number = randomGenerator.Next(1, 101);
            int guessCount = 0;

            do
            {  
                guessCount++;
                Console.Write("Guess what the magic number is? ");
                string guess = Console.ReadLine();
                correct = int.Parse(guess);

                if (correct < number)
                {
                    Console.WriteLine("Higher ");
                }
                else if (correct > number)
                {
                    Console.WriteLine("Lower ");
                }
                else
                {
                    Console.WriteLine($"You Guessed it! It took you {guessCount} guesses!");
                }

            } while (correct != number);
            
            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();
            
        } while (answer != "no");
        Console.WriteLine("Thanks for playing!");
    }
}