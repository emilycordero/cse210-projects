
using System;
using System.IO;
using System.Collections.Generic;
using static Scripture;
using static Word;
using static Reference;

class Program
{
    static void Main(string[] args)
    {
        string reference = "John 3:16";
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, text);


        Console.WriteLine(scripture);
        Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

        string input = Console.ReadLine();
        if (input.ToLower() == "quit")
        {
            return;
        }


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
