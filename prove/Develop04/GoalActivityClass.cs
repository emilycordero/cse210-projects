using System;

public class GoalActivityClass : RunActivityClass
{
    public GoalActivityClass() : base("Goal Activity", "This activity will help remind you to set a goal and maintain your goals.")
	{
        
    }
    protected override void PerformActivity()
    {
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();

        Console.WriteLine("Start listing as many goals as you want:");


        int listingDuration = 20;
        DateTime endTime = DateTime.Now.AddSeconds(listingDuration);

        List<string> itemList = new List<string>();
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemList.Add(item);
            itemCount++;
        }

        Console.WriteLine($"Time's up! Listing is complete. You listed {itemCount} items.");
    }


}
