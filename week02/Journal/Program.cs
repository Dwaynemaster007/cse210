using System;

// ----------------------------------------------------------------------
//  Creativity notes:
// - Added a "mood" field to each Entry, so the user records how they were
//   feeling alongside their written response. This saves additional
//   information beyond the core date/prompt/text requirement, and helps
//   address a reason people avoid journaling (not knowing what to write) -
//   a quick mood tag gives them something easy to record even on days
//   they don't feel like writing much.
// - Added a few extra prompts to the PromptGenerator beyond the required five.
// - LoadFromFile gracefully handles a missing file and skips malformed
//   lines instead of crashing.
// ----------------------------------------------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("That is not a valid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    private static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("How are you feeling right now? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(date, prompt, response, mood);
        journal.AddEntry(newEntry);
    }
}
