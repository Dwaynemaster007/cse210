using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Using "~|~" as a separator that is very unlikely to show up
    // naturally in someone's journal entry text.
    private const string Separator = "~|~";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the journal yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            // The Journal doesn't need to know HOW an entry displays itself,
            // it just asks the entry to display itself. This is the benefit
            // of giving Entry its own Display method.
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString(Separator));
            }
        }

        Console.WriteLine($"Journal saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"Could not find file: {file}");
            return;
        }

        // Loading replaces any entries currently stored in the journal.
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            string[] parts = line.Split(Separator);

            if (parts.Length < 4)
            {
                continue; // skip malformed lines
            }

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            string mood = parts[3];

            loadedEntries.Add(new Entry(date, promptText, entryText, mood));
        }

        _entries = loadedEntries;
        Console.WriteLine($"Journal loaded from {file}");
    }
}
