using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type
        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimming = new Swimming("05 Nov 2022", 30, 20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
