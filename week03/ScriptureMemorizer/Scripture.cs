using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordStrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Only select from words that are not already hidden, so repeated
        // calls don't waste a "hide" on a word that's already gone.
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        List<string> wordDisplays = new List<string>();
        foreach (Word word in _words)
        {
            wordDisplays.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", wordDisplays);
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}