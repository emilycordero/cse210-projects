using System;

public class ReflectingActivityClass : RunActivityClass
{
    public ReflectingActivityClass() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }
    protected override void PerformActivity()
    {
        Console.WriteLine("Consider the following prompt: ");
        GeneratePromptClass generatePromptClass = new GeneratePromptClass();
        generatePromptClass.GenerateReflectionPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadKey();
        Console.Write("Now, ponder on each of the following questions as they relate to this experience. ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        Console.WriteLine();
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        generatePromptClass.generateReflectionQuestions();
        Thread.Sleep(8000);
    }
}
