using System;
using System.IO;
using System.Collections.Generic;

class GeneratePromptClass
{
    public GeneratePromptClass()
    {
        
    }

    public void GenerateReflectionPrompt()
    {
        
        Random random = new Random();
        List<string> promptList = new List<string>();
        promptList.Add("Describe a time when you stood up for someone else.");
        promptList.Add("Recall a time when you failed at something.");
        promptList.Add("Describe what motivates you during difficult times. ");
        promptList.Add("Imagine that you are granted the power to do one thing of your choosing perfectly on the first try, every time you try it.");
        promptList.Add("Think about something in the world that no one can explain and then write your own fictional story to explain it.");
        promptList.Add("Imagine that you wake up one day and a daydream of yours has come true overnight.");
        int randomIndex = random.Next(0, promptList.Count);
        string prompt = promptList[randomIndex].Trim();

        Console.WriteLine(prompt);
    }
    public void GenerateListingPrompt()
    {

        Random random = new Random();
        List<string> promptList = new List<string>();
        promptList.Add("Who are people that you appreciate?");
        promptList.Add("What are personal strengths of yours?");
        promptList.Add("Who are people that you have helped this week?");
        promptList.Add("When have you felt the Holy Ghost this month?");
        promptList.Add("Who are some of your personal heroes?");

        int randomIndex = random.Next(0, promptList.Count);
        string prompt = promptList[randomIndex].Trim();

        Console.WriteLine(prompt);
    }

    public void generateReflectionQuestions()
    {
        List<string> reflectionQList = new List<string>();
        reflectionQList.Add("Why was this experience meaningful to you?");
        reflectionQList.Add("How did it start?");
        reflectionQList.Add("Have you ever done anything like this before?");
        reflectionQList.Add("How did you feel when it was complete?");
        reflectionQList.Add("What made this time different than other times when you were not as successful?");
        reflectionQList.Add("What is your favorite thing about this experience?");
        reflectionQList.Add("What could you learn from this experience that applies to other situations?");
        reflectionQList.Add("What did you learn about yourself through this experience?");
        reflectionQList.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();

        int randomIndex = random.Next(0, reflectionQList.Count);
        string reflectionQ = reflectionQList[randomIndex].Trim();

        Console.WriteLine(reflectionQ);

    }
    public void generateListingQuestions()
    {
        List<string> listQList = new List<string>();
        listQList.Add("Who are people that you appreciate?");
        listQList.Add("What are personal strengths of yours?");
        listQList.Add("Who are people that you have helped this week?");
        listQList.Add("When have you felt the Holy Ghost this month?");
        listQList.Add("Who are some of your personal heroes?");

        Random random = new Random();

        int randomIndex = random.Next(0, listQList.Count);
        string listQ = listQList[randomIndex].Trim();

        Console.WriteLine(listQ);

    }
}

