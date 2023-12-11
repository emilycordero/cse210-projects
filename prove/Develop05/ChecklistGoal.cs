using System;

public class ChecklistGoal : Goal
{
    public int CompletionCount { get; private set; }
    public int DesiredCount { get; private set; }
    public int BonusPoints { get; private set; }
    public ChecklistGoal(string goalName, string goalDescription, int numberOfPoints, int desiredCount, int bonusPoints) : base(goalName, goalDescription, numberOfPoints)
    {
        DesiredCount = desiredCount;
        BonusPoints = bonusPoints;

      
    }

    public override void RecordEvent()
    {
        CompletionCount++;
    }

    public override bool IsCompleted()
    {
        return CompletionCount >= DesiredCount;
    }
}