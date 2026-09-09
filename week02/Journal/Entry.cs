using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Expose read-only access to the data so other classes (like Journal)
    // can use it for saving to a file, without exposing the raw fields directly.
    public string GetDate()
    {
        return _date;
    }

    public string GetPromptText()
    {
        return _promptText;
    }

    public string GetEntryText()
    {
        return _entryText;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }

    // Converts the entry into a single line of text, using the given
    // separator, so the Journal class can write it to a file.
    public string ToFileString(string separator)
    {
        return $"{_date}{separator}{_promptText}{separator}{_entryText}";
    }
}
