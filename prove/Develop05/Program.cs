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
        List<Goal> goals = new List<Goal>();
        switch (choice)
        {
            case "1":
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                    SimpleGoal simpleGoal = new SimpleGoal();
                    goals.Add(simpleGoal);
                    break;
                elseif(userChoice == "2");
                EternalGoal eternalGoal = new EternalGoal();
                goals.Add(eternalGoal);
                    break;
                elseif(userChoice == "3");
                ChecklistGoal checklistGoal = new ChecklistGoal();
                    break;
                goals.Add(checklistGoal);
                foreach (Goal g in goals)
                {
                    string goal = g.GetGoal();
                    Console.WriteLine(goal);
                }
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
}