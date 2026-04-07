using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _count = 0;
    private List<Comment> _comments = new List<Comment>();


    public Video(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _length = Length;
    }
    public void AddComment(Comment comment)
    { 
        _comments.Add(comment);
        _count ++;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine();
        Console.WriteLine("COMMENTS:");
        Console.WriteLine();

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine($"{_count} Comments");
        Console.WriteLine();
    }
};