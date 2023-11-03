using Microsoft.TeamFoundation.Client.CommandLine;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            return Environment.Exit(ExitCode);
        }

        while (!scripture.AllWordsHidden())
        {
            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture);

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.")

            string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return Environment.Exit();
                }
        }

    }
}
class Scripture
{
    private string reference;
    private string text;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;   
        this.words = new List<Word>();

        // by using .Split method we will split the scripture text into words
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray )
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);

        // Hide word at the random index if it is not already hidden
        if (!words[index].IsHidden())
        {
            words[index].Hide();
        }
        else
        {
            // if already hidden
            HideRandomWord();
        }
    }

    // in the instance all words hidden, return true to exit program
    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        string reconstructedText = "";
        foreach(Word word in words)
        {
            reconstructedText = +word = " ";
        }

        return $"{reference}: {reconstructedText}";
    }
}
class Reference
{
    private string referenceText;

    public Reference(string referenceText)
    {
        this.referenceText = referenceText;
    }

    // Methods to handle single and multiple verse ranges

}
class Word
{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        this.hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public void IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        if (hidden)
        {
            return "______";
        }
        return word;
    }
}
