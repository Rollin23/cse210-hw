public class Listening : Activity
{
    private static string[] questions =
    {
        "When have you felt the Holy Ghost this month?",
        "What were your favorite scriptures you read this month",
        "What were some times you felt your faith increase this month?",
        "What are some blessings that happened for you this month?",
        "Who do you want to serve better next month?",
        "What spiritual principals do you want to focus on next month?"      
    };
    private int _count = 0;
    public Listening() : base("Listening", "This activity will help You reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        
    }
    public void RunListen()
    {
        OpeningMessage();
        GetDuration();

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Random rand = new Random();
        int i = rand.Next(questions.Length);
        Console.WriteLine($" --- {questions[i]} --- ");

        for(int y = 5; y > 0; y--)
        {
            Console.Write($"\rYou may begin in.. {y}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b \b");
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }



        Console.WriteLine($"You Listed {_count} items!!");
        ClosingMessage();

    }
}
