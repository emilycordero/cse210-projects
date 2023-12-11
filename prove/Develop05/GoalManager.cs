using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class GoalManager
{
	public List<Goal> goals;
	public UserPoints userPoints;

	public GoalManager(string user)
	{
		goals = new List<Goal>();
		userPoints = new UserPoints(user, 0);

	}

	public void CreateGoal(string goalType, string goalName, string goalDescription, int numberOfPoints, int desiredCount, int bonusPoints)
	{
		switch (goalType)
		{
			case "1":
                goals.Add(new SimpleGoal(goalName, goalDescription, numberOfPoints, userPoints));
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, goalDescription, numberOfPoints));
                break;
            case "3":
                
                goals.Add(new ChecklistGoal(goalName, goalDescription, numberOfPoints, desiredCount, bonusPoints));
				break;
			default:
				Console.WriteLine("Invalid goal type.");
					break;
        }
	}

	public void RecordEvent()
	{
        int lastIndex = goals.Count - 1;
        if (lastIndex >= 0 && lastIndex < goals.Count)
		{
			goals[lastIndex].RecordEvent();
		}
		else
		{
			Console.WriteLine("Invalid goal index.");
		}
	}
	public void SaveGoals(List<Goal> goals,string filename)
	{
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
			List<string> goalData = new List<string>();
            foreach (Goal goal in goals)
            {
                string data = $"{goal.goalName},{goal.goalDescription},{goal.numberOfPoints}";
                goalData.Add(data);
            }
        }
    }
   public List<Goal> LoadGoals(List<Goal> goals,string filePath)
        {

            if (File.Exists(filePath))
            {
                string[] goalData = File.ReadAllLines(filePath);

                foreach (string data in goalData)
                {
                    string[] parts = data.Split(',');

                    if (parts.Length == 3)
                    {
                        string goalName = parts[0];
                        string goalDescription = parts[1];
                        int numberOfPoints = int.Parse(parts[2]);
                        Goal goal = new ConcreteGoal(goalName, goalDescription, numberOfPoints, userPoints);
                        goals.Add(goal);
                    }
                }
            }
        return goals;
    }

   
    public void DisplayScore()
	{
		Console.WriteLine($"Your score is: {userPoints.Score}");
	}

	public void DisplayGoals()
	{
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];

			if (!goal.IsCompleted())
			{
                Console.Write($"{i + 1}. [ ]  {goal.goalName} ({goal.goalDescription})");
            }
			else
			{
                Console.Write($"{i + 1}. [X]  {goal.goalName} ({goal.goalDescription})");
            }

			if (goal is ChecklistGoal checklistGoal)
			{
				Console.Write($" -- Currently completed: {checklistGoal.CompletionCount}/{checklistGoal.DesiredCount}");
			}
			Console.WriteLine();

        }
    }
}
