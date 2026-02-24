using System;

public class Entry
{
    private Reference _reference;
    private List<Word> _text = new();

    public Entry(Reference reference, string text)
    {
        _reference = reference;

        _text = new List<Word>();
        
        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            _text.Add(new Word(word));
        }
    }

}