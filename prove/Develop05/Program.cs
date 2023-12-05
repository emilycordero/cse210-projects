using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }