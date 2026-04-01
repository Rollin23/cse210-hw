using System;
public class Comment
{
    private string _name;
    private string _comment;
    public void SetComment(string Name, string Comment)
    {
        _name = Name;
        _comment = Comment;
    }
    public string GetName()
    { 
        return _name;
    }

    public string GetComment()
    { 
        return _comment;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
        Console.WriteLine("------------------------------------------------------------------------");
    }
}