using System;

public class Entry
{
    public string _question;
    public string _response;
    public string _date; 
    
    // private static DateTime theCurrentTime = DateTime.Now;

    private static string[] questions = 
    {
        "What is one of your favorite memories from the past?",
        "What's something you've always dreamed of doing?",
        "Can you think of something you're especially grateful for recently?",
        "Name one thing you that's within your power to change?",
        "Who is someone you admire deeply. What about them specifically?"
    };
    public static Entry GetEntry()
    {

        Random rand = new Random();
        int i = rand.Next(questions.Length);
        string question = questions[i];

        Console.WriteLine($"{question}");
        Console.Write(">");
        string response = Console.ReadLine();

        Entry e1 = new Entry();
        e1._date = DateTime.Now.ToShortDateString();
        e1._question = question;
        e1._response = response;

        return e1; 
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} – Prompt: {_question}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

}