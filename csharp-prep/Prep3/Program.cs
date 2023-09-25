using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //string userInput = Console.ReadLine();
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guess = -1;
        int count = 0;
        string response = "yes";
       do
        {while (guess != magicNumber)
            {
             Console.WriteLine("What is your guess? ");
            string userInput2 = Console.ReadLine();
            guess = int.Parse(userInput2);
            count += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {count} times.");
                Console.Write("Do you want to play again? ");
                response = Console.ReadLine();
            }
        }} while (response == "yes");
    }
}