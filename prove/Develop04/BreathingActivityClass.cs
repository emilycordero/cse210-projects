using System;
using System.Xml.Linq;

public class BreathingActivityClass
{
    private DateTime startTime;
    private DateTime futureTime;
    private int duration;
    public int Duration { get; set; }
    public BreathingActivityClass()
    {
        string name = "Breathing Activity";
        string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.WriteLine($"Welcome to {name}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write("Enter the duration in seconds you'd like this session to take: ");
        Console.WriteLine();
        string userInput = Console.ReadLine();
        int duration = int.Parse(userInput);
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(duration);

        Console.WriteLine("Get ready to begin...");
        animationStrings();

        while (DateTime.Now < futureTime) // Add condition to check if current time has exceeded future time
        {
            breathIn();
            Thread.Sleep(1000);
            Console.WriteLine();
            breathOut();
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        Console.WriteLine("Good Job!");
        animationStrings();
        Console.WriteLine($"You have completed {duration} seconds of the {name}.");

    }
    
    public void animationStrings()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings) 
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void breathIn()
    {
        string breath = "Breathe in... ";
        Console.Write($"{breath}");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void breathOut()
    {
        string breath = "Now breathe out... ";
        Console.Write($"{breath}");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}