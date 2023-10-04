using System;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Collections.Generic;

class JournalEntry
{
    public string Prompt { get; set; }
    public DateTime CreatedDate { get; set;}

    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Created Date: {CreatedDate}");
        Console.WriteLine();
    }

}

class Journal 
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt)
    {
        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            CreatedDate = DateTime.Now
            
        };
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in entries){
            entry.Display();
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.CreatedDate);
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        entries.Clear();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string prompt = reader.ReadLine();
                DateTime createdDate = DateTime.Parse(reader.ReadLine());

                JournalEntry entry = new JournalEntry
                {
                    Prompt = prompt,
                    CreatedDate = createdDate
                };
                entries.Add(entry);
            }
        }
    }
}
class Program
{
    static List<string> entries = new List<string>();

    public static string filePath { get; private set; }
    public static string prompt { get; private set; }

    public static void Main()
    {
        Journal journal = new Journal();
        
        while(true){
        Console.WriteLine("Please select from the following: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.WriteLine("What would you like to do? ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                journal.AddEntry(prompt);
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                journal.SaveToFile(filePath);
                break;
            case "4":
                journal.LoadFromFile(filePath);
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:

Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

class PromptGenerator
{
    public string Prompt { get; set; }

    public void DisplayPrompt()
    {
        string[] prompts = File.ReadAllLines("prompts.txt");

        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Length);
        string prompt = prompts[randomIndex];
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine();
    }

}
public void AddEntry()
{
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    List<string> entries = new List<string>();

    string[] prompts = File.ReadAllLines("prompts.txt");

    PromptGenerator prompt = new PromptGenerator();
    Random random = new Random();
    int randomIndex = random.Next(0, prompts.Length);
    string promptUser = prompts[randomIndex];
    Console.WriteLine($"Prompt: {promptUser}");
    Console.WriteLine();
    Console.WriteLine("Enter your entry: ");
    string entryInput = Console.ReadLine();
    entries.Add(dateText);
    entries.Add(entryInput);
    Console.WriteLine("Entry added successfully!");
    Console.WriteLine();
}
}