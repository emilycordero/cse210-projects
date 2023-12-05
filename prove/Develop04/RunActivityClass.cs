using System;
using System.Threading;
using System.Xml.Linq;

public class RunActivityClass
{
    protected DateTime startTime;
    protected DateTime futureTime;
    public int Duration { get; set; }

    public RunActivityClass(string name, string description)
    {
        Console.WriteLine($"Welcome to {name}.");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write("Enter the duration in seconds you'd like this session to take: ");
        string userInput = Console.ReadLine();
        int duration = int.Parse(userInput);
        Duration = duration;
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(duration);

        Console.WriteLine("Get ready to begin...");
        animationStrings();

        while (DateTime.Now < futureTime)
        {
            PerformActivity();
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        Console.WriteLine("Good Job!");
        animationStrings();
        Console.WriteLine($"You have completed {duration} seconds of the {name}.");
    }

    protected virtual void PerformActivity()
    {
        // Common activity logic to be implemented by derived classes
    }

    private void animationStrings()
    {
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}
