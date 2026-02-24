using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Rollins", "Math");
        Console.WriteLine(assignment1.GetSummary());
        

        MathAssignment mathAssignment1 = new MathAssignment("Michael Rollins", "Math", "Algebra", "15-25");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Cathryn Rollins", "Writing", "The Magic Staff");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}