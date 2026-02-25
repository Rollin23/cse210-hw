using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new();
    private Random _random;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _text = new List<Word>();
        _random = new Random();
        
        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            _text.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        scriptureText = _reference.GetReference() + " ";

        foreach (Word word in _text)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return scriptureText;
    }

    public void HideRandomWords(int WordsToHide)
    {
        int count = 0;
        while (count < WordsToHide && !AllWordsHidden())
        {
            int index = _random.Next(0, _text.Count);
            if (!_text[index].IsHidden())
            {
                _text[index].Hide();
                count++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _text)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}