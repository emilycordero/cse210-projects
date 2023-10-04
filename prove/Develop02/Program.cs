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

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        while(true){
        Console.WriteLine("Please select from the following: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.WriteLine("What would you like to do? ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AddEntry();
                break;
            case "2":
                DisplayEntries();
                break;
            case "3":
                SaveToFile();
                break;
            case "4":
                LoadFromFile();
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

public void AddEntry()
{
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    Journal journal = new Journal();

    string[] prompts = File.ReadAllLines("prompts.txt");

    Random random = new Random();
    int randomIndex = random.Next(0, prompts.Length);
    string prompt = prompts[randomIndex];
    journal.AddEntry(prompt);
    Console.WriteLine(prompt);
    Console.WriteLine("Enter your entry: ");
    string entryInput = Console.ReadLine();
    entries.Add(dateText);
    entries.Add(entryInput);
    Console.WriteLine("Entry added successfully!");
    Console.WriteLine();
}

public void DisplayEntries()
{
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    Console.WriteLine("All entries: ");
    foreach (string entry in entries)
    {
        Console.WriteLine(dateText + entry);
    }
    Console.WriteLine();
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

public void LoadFromFile()
{
    Console.WriteLine("Enter the file path to load the entries from: ");
    string filePath = Console.ReadLine();
    entries.Clear();
    using (StreamReader reader = new StreamReader(filePath))
    {
        while (!reader.EndOfStream)
        {
            string entry = reader.ReadLine();
            entries.Add(entry);
        }
    }
    Console.WriteLine($"Entries loaded from file: {filePath}");
    Console.WriteLine();
    }
}