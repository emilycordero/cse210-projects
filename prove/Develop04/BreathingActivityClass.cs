using System;
using System.Xml.Linq;

public class BreathingActivityClass : RunActivityClass
{
    public BreathingActivityClass() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    protected override void PerformActivity()
    {
        breathIn();
        Thread.Sleep(1000);
        Console.WriteLine();
        breathOut();
        Thread.Sleep(1000);
        Console.WriteLine();
    }

    private void breathIn()
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

    private void breathOut()
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