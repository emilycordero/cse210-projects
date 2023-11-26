using System;

public class ListingActivityClass
{
    private DateTime startTime;
    private DateTime futureTime;
    private int duration;
    public ListingActivityClass()
	{
        string name = "Listing Activity";
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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
        
        Console.Write("List as many responses you can to the following prompt:  ");
        GeneratePromptClass generatePromptClass = new GeneratePromptClass();
        generatePromptClass.GenerateListingPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
        
        Console.WriteLine("Start listing items:");

       
        int listingDuration = 20; 
        DateTime endTime = DateTime.Now.AddSeconds(listingDuration);

        
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"Time's up! Listing is complete. You listed {itemCount} items.");
        Console.WriteLine();
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
