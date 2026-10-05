using System;

// EXCEEDING REQUIREMENTS:
// 1. Added a level system based on score (every 1000 points = 1 level).
// 2. When the user records an event, the program shows their current level
//    and encourages them with a short motivational message.
// 3. The level is also shown next to the score in the main menu.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
