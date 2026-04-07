using System;
public class Comment
{
    private string _name;
    private string _comment;
    public Comment(string Name, string Comment)
    {
        _name = Name;
        _comment = Comment;
    }
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine("------------------------------------------------------------------------");
    }
}