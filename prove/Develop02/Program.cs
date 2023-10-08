using System;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Collections.Generic;

class JournalEntry
{
    public string _entryPrompt;
    public string _entryText;
    public DateTime _entryDate;
    DateTime theCurrentTime = DateTime.Now;
    
    
    public void Display()
    {
        Console.WriteLine($"Created Date: {_entryDate} Prompt: {_entryPrompt} Entry: {_entryText}");
    }

}

public class Journal 
{

    List<JournalEntry> entries = new List<JournalEntry>();

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
        Console.WriteLine("What is the file path? ");
        filePath = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine(entry._entryDate);
                writer.WriteLine(entry._entryPrompt);
                writer.WriteLine(entry._entryText);
            }
        }
    }

public void LoadFromFile(string filePath)
        {
            entries.Clear();
            Console.WriteLine("What is the file path? ");
            filePath = Console.ReadLine();

            
            if (string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("Invalid file path!");
                return;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string prompt = reader.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToString("MM/dd/yyyy HH:mm:ss");

                if (DateTime.TryParse(dateText, out DateTime entryDate))
                {
                    JournalEntry entry = new JournalEntry
                    {
                        _entryPrompt = prompt,
                        _entryDate = entryDate
                    };
                    entries.Add(entry);
                }
                else
                {
                    Console.WriteLine("Invalid date format!");
                }
            }
            }
        }
}




    public class PromptGenerator
    {
        public Journal journal = new Journal();

        public string[] _prompts = {
            "List 3 of your fears",
            "Write down 3 of your strengths",
            "Write down 3 reasons that make you unique",
            "Write about your favorite childhood memory",
            "Write about a smell that reminds you of home",
            "How happy are you with your current relationship?",
            "Are you progressing in your career?",
            "What are the things that are stopping you from going after your goals?",
            "Where do you see yourself 5 years from now?",
            "What would you tell your future self?",
        };
        public void GeneratePrompt()
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToString("MM/dd/yyyy HH:mm:ss");

            string prompt = ReturnPrompt();
            Console.WriteLine($"Prompt: {prompt}");
        }

        private string ReturnPrompt()
        {
            // Implementation of the ReturnPrompt method
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(0,10);
            string prompt = _prompts[i];
            return prompt;
        }

        private string GetEntryInput()
        {
            Console.WriteLine("Enter your entry: ");
            return Console.ReadLine();
        }
    }

        class Program
{
    static List<string> entries = new List<string>();

    public static string prompt { get; private set; }
    public static string entryInput { get; private set; }
    public static string dateText { get; private set; }
    public static string filePath { get; private set; }

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
                AddEntry();
                break;
            case "2":
                journal.DisplayEntries();
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