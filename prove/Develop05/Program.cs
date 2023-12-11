class Program
{
    static void Main(string[] args)
    {
        string name = "User";
        GoalManager goalManager = new GoalManager(name);
        Console.WriteLine();
        Console.WriteLine($"You have {goalManager.userPoints.Score} points.");
        Console.WriteLine();

        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        
        while (choice != "6")
        {   
            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                Console.WriteLine("What is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int numberOfPoints = int.Parse(Console.ReadLine());

                if (goalType == "3")
                {
                    Console.WriteLine("How many times does this goal need to be accomplished for bonus? ");
                    int desiredCount = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing this goal? ");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    goalManager.CreateGoal(goalType, goalName, goalDescription, numberOfPoints, desiredCount, bonusPoints);
                }
                else
                {
                    int desiredCount = 0;
                    int bonusPoints = 0;
                    goalManager.CreateGoal(goalType, goalName, goalDescription, numberOfPoints, desiredCount, bonusPoints);
                }
                Console.WriteLine("Goal created successfully.");
            }
            else if (choice == "2") 
            {
                goalManager.DisplayGoals();
                Console.WriteLine();
            }
            else if(choice == "3") 
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.SaveGoals(goalManager.goals, filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                goalManager.LoadGoals(goalManager.goals, filename);
            }
            else if (choice == "5")
            {
                goalManager.RecordEvent();
            }
            else if (choice == "6")
            {
                Environment.Exit(0);
                break;
            }
            else
            {
                break;
            }
            Console.WriteLine();
            Console.WriteLine($"You have {goalManager.userPoints.Score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
        }
    }
}