﻿using System;

public class ListingActivityClass : RunActivityClass
{
    public ListingActivityClass() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
	{
        
    }
    protected override void PerformActivity()
    {
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
    }
}
