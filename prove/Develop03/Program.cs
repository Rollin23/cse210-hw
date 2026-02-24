using System;

class Program
{
    static void Main(string[] args)
    {
        
        // 1. Store a scripture, including both the reference 
        // (for example "John 3:16") and the text of the scripture.
       
        // 2. Accommodate scriptures with multiple verses, such as 
        // "Proverbs 3:5-6".
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";   

        // 3.Clear the console screen and display the complete scripture, 
        // including the reference and the text.
        Console.Clear();
        Console.WriteLine($"{reference1.GetReference()}: {text}");

        // 4.Prompt the user to press the enter key or type quit.
        Console.WriteLine("Press the enter key to hide a word or type 'quit' to exit.");
        Console.Write(">");
        string userInput = Console.ReadLine();

        // 5. If the user types quit, the program should end.
        if (userInput.ToLower() == "quit")
        {
            return;
        }

        // 6. If the user presses the enter key (without typing quit), 
        // the program should hide a few random words in the scripture, 
        // clear the console screen, and display the scripture again.

        // 7.The program should continue prompting the user and hiding more 
        // words until all words in the scripture are hidden.

        // 8.When all words in the scripture are hidden, the program should 
        // end.

        // 9. When selecting the random words to hide, for the core 
        // requirements, you can select any word at random, even if the word 
        // was already hidden. (As a stretch challenge, try to randomly select 
        // from only those words that are not already hidden.)
    }
}