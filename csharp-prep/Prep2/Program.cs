using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        if (grade >= 90)
        {
            letter = ("A");
        }
        else if (grade >= 80)
        {
            letter = ("B");
        }
        else if (grade >= 70)
        {
            letter = ("C");
        }
        else if (grade >= 60)
        {
            letter = ("D");
        }
        else if (grade < 60)
        {
            letter = ("F");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        int lastdigit = (grade%10);
        if (lastdigit >= 7)
            {
                Console.WriteLine($"{letter}+");
            }
        else if (lastdigit < 3)
            {
                Console.WriteLine($"{letter}-");
            }
        else if (lastdigit == 0)
        {
            Console.WriteLine($"{letter}");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else if (grade <= 69)
        {
            Console.WriteLine("You didn't pass the class, better luck next time!");
        }
        else{
            Console.WriteLine("Invalid.");
        }
    }
}