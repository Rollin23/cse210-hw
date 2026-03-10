public class Breathing : Activity
{
    
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ", 0)
    {
        
    }
    public void RunBreath()
    {
        OpeningMessage();
        GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);



        while (DateTime.Now < futureTime)
        {
            for (int i = 4; i > 0; i--)
            {
                if (DateTime.Now >= futureTime) break;
                Console.Write($"\rBreathe in...{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");

            
            }
            Console.WriteLine("");
            for (int i = 6; i > 0; i--)
            {
                if (DateTime.Now >= futureTime) break;
                Console.Write($"\rNow breathe out...{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");
            Console.WriteLine("");

        }

        ClosingMessage();
    }
}
