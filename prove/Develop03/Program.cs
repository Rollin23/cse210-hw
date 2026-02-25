using System;

class Program
{
    static void Main(string[] args)
    {
       Reference ref1 = new Reference("Nephi", 7, 8);
       Scripture sc1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them. And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord.");
       Console.WriteLine(sc1.GetDisplayText());
        while (!sc1.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(sc1.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine(sc1.GetDisplayText());
                break;
            }
            sc1.HideRandomWords(3);
        }

    }

}