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

    

    public void AddEntry(string prompt, string entryInput, string dateText)
{
    DateTime theCurrentTime = DateTime.Now;
    dateText = theCurrentTime.ToString("MM/dd/yyyy HH:mm:ss");
    
    
    Console.WriteLine("Enter your entry: ");
    string _entryText = Console.ReadLine();
    JournalEntry entry = new JournalEntry
    {
        _entryPrompt = prompt,
        _entryText = entryInput,
        _entryDate = DateTime.Parse(dateText)
    };

    entries.Add(entry);

    Console.WriteLine("Entry added successfully!");
    Console.WriteLine();
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
                PromptGenerator promptGenerator = new PromptGenerator();
                promptGenerator.GeneratePrompt();
                journal.AddEntry(prompt, entryInput, dateText);
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                journal.LoadFromFile(filePath);
                break;  
            case "4":
                journal.SaveToFile(filePath);
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
}