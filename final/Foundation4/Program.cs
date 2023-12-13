using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // List of activities
        List<Activity> activities = new List<Activity>();

        // Activity objects
        Activity running = new Running("Morning Run", 45, 4);
        activities.Add(running);

        Activity swimming = new Swimming("Afternoon swim", 21, 5);
        activities.Add(swimming);

        Activity cycling = new Cycling("Evening Cycling", 15, 5);
        activities.Add(cycling);

        // Iteration through list for GetSummary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }


    }
}