public class Reflection : Activity
{
    private static string[] prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] thoughtPrompt =
    {
        "How did you feel when it was complete?",
        "If you could go back what would you do different?",
        "What is one lesson you learned?",
        "What was something that helped you through it?",
        "Would you ever want do it again?",
        "How has this experience shaped your life?"
    };

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {

    }

    public void RunReflect()
    {
        
        OpeningMessage();
        GetDuration();
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine("");
        Random rand = new Random();
        int i = rand.Next(prompts.Length);
        Console.WriteLine($" ---{prompts[i]}--- ");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        
        for (int y = 5; y > 0; y--)
        {
            Console.Write($"\rYou may begin in: {y}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            int y = rand.Next(thoughtPrompt.Length); 
            Console.Write($" {thoughtPrompt[y]}");

            Spinner();
            Console.WriteLine();
        }

        ClosingMessage();     

    }

}