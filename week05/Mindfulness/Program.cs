using System;
using Mindfulness;

// EXCEEDING REQUIREMENTS:
// 1. Added a session log counter that tracks how many activities the user completes during the program session.
// 2. Displays the total activities completed in the main menu before exiting.

class Program
{
    static void Main(string[] args)
    {
        int activityCount = 0;
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine($"\nActivities completed this session: {activityCount}");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                activityCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activityCount++;
            }
        }

        Console.WriteLine($"\nThank you for taking time for mindfulness today. Total completed: {activityCount}");
    }
}