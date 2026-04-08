using System;

class Program
{
    static void Main(string[] args)
    {
        Address add1 = new Address("156 Grey st.", "Arvada", "Colorado", "USA");
        Event e1 = new Event("Bake Sale", "Girlscouts troop 334 will be selling baked goods in front of the school.", "January 3rd 3:00pm", add1, "Normal Event");
        Console.WriteLine(e1.GetShortDetails());
        Console.WriteLine(e1.GetStandardDetails());
        Console.WriteLine(e1.GetFullDetails());

        Address add2 = new Address("3524 Feonton Ave.", "Jackson", "Mississippi", "USA");
        Lecture l1 = new Lecture("Melanomas", "Medical conference where there will be lectures on new procedures to remove melanomas", "July, 4th 2026 5:00pm", add2, "Lecture", "Dr.House", 300);
        Console.WriteLine(l1.GetShortDetails());
        Console.WriteLine(l1.GetFullDetails());
        Console.WriteLine(l1.GetLectureEvent());
        Console.WriteLine(l1.GetStandardDetails());

        Address add3 = new Address("1568 Adams crt.", "Driggs", "Idaho", "USA");
        Outdoor o1 = new Outdoor("Town Picnic", "The down does a yearly picnic at the park", "July 13, 2026", add3, "Outdoor", "Sunny");
        Console.WriteLine(o1.GetShortDetails());
        Console.WriteLine(o1.GetFullDetails());
        Console.WriteLine(o1.GetOutdoorEvent());
        Console.WriteLine(o1.GetStandardDetails());

        Address add4 = new Address("654 Monty st.", "Nantucket", "Alabama", "USA");
        Reception r1 = new Reception("Wednesday Adams", "Wedding reception in a graveyard", "October 13, 2026", add4, "Reception", "WednesdayAdam666@criptmail.com");
        Console.WriteLine(r1.GetShortDetails());
        Console.WriteLine(r1.GetFullDetails());
        Console.WriteLine(r1.GetReceptionEvent());
        Console.WriteLine(r1.GetStandardDetails());
    }
}