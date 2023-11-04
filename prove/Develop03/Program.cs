using Microsoft.TeamFoundation;
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, text);
  

        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            return;
        }
        Console.WriteLine(scripture);


        while (!scripture.AllWordsHidden())
        {
            scripture.HideRandomWord();
            Console.WriteLine(scripture);

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            input = Console.ReadLine();

               if (input.ToLower() == "quit")
               {
                    Console.Clear();

                    return;
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
        if (words[index].IsHidden())
        {
            // if already hidden
            HideRandomWord();
        }
        else
        {
            words[index].Hide();
        }
    }

    // in the instance all words hidden, return true to exit program
    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                continue;
            }
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        string reconstructedText = "";
        foreach(Word word in words)
        {
            reconstructedText += " " + word;
        }

        return $"{reference}: {reconstructedText}";
    }
}
class Reference
{
    private string reference;
    private string text;
    private string filepath = "scriptures.txt";
    // i couldn't figure out how to read and return a random scripture from a separate file but i tried to 

    public Reference(string reference, string filepath)
    {
        this.reference = reference;
        this.text = File.ReadAllText(filepath);
    }
    public string GetRandomScripture()
    {
        string[] scriptures = this.text.Split('.');
        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Length);
        return scriptures[randomIndex].Trim();
    }
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

    public bool Hide() => hidden = true;

    public bool IsHidden()
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
