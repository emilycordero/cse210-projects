using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int numberOfPoints, UserPoints UserPoints) : base(goalName, goalDescription, numberOfPoints)
    {
        

    }

    public override void RecordEvent()
    {
        UserPoints userPoints = new UserPoints(goalName, numberOfPoints);
        userPoints.AddPoints(numberOfPoints);
    }
    public override bool IsCompleted()
    {
        return true;
    }
}
