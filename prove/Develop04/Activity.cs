using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected string _closingMessage = "";

    protected int _duration = 0;

        public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void OpeningMessage()
    {
        Console.WriteLine("\b \b");
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        
    }

    public void GetDuration()
    {
        Console.Write("How long, in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.Clear();

    }
    public void ClosingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Spinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        Spinner();
        Console.Clear();
    }
    public void GetTimer()
    {
        Console.Write("How long, in seconds, would you like for your session?  ");
        _duration = int.Parse(Console.ReadLine());
    }

    public static void Spinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        for (int i = 0; i < 4; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(400);
                Console.Write("\b \b");
            }
        }
    }

        public static void Spinner2()
    {
        List<string> spinner = new List<string>();
        spinner.Add("o");
        spinner.Add("x");
        spinner.Add("*");
        spinner.Add("+");
        for (int i = 0; i < 4; i++)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(400);
                Console.Write("\b \b");
            }
        }
    }

}
