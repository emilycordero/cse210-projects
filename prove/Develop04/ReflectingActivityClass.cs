using System;
using static GeneratePromptClass;

public class ReflectingActivityClass
{
    private DateTime startTime;
    private DateTime futureTime;
    public ReflectingActivityClass()
	{
        string name = "Reflecting Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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
        Console.WriteLine("Consider the following prompt: ");
        GeneratePromptClass generatePromptClass = new GeneratePromptClass();
        generatePromptClass.GenerateReflectionPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadKey();
        Console.Write("Now, ponder on each of the following questions as they relate to this experience. ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        while (DateTime.Now < futureTime) // Add condition to check if current time has exceeded future time
        {
            generatePromptClass.generateReflectionQuestions();
            animationStrings();
            Thread.Sleep(1000);
            Console.WriteLine();
        }
        Console.WriteLine();
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

}
