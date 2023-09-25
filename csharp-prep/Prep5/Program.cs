using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static void PromptUserName(string userName)
    {
        Console.WriteLine("What is your user name? ");
        userName = Console.ReadLine();
    }
    static void PromptUserNumber(int userNumber)
    {
        Console.WriteLine("What is your favorite number? ");
        string userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);
    }
    static int SquareNumber(int userNumber, int squareNumber)
    {
        Console.WriteLine("What is the number? ");
        string userInput2 = Console.ReadLine();
        int number = int.Parse(userInput2);
        squareNumber *= number;
        return squareNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}