using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int numberOfPoints) : base(goalName, goalDescription, numberOfPoints)
    {

    }
    public override void RecordEvent()
    {
        UserPoints userPoints = new UserPoints(goalName, numberOfPoints);
        userPoints.AddPoints(numberOfPoints);
    }

    public override bool IsCompleted()
    {
        // they are never completed
        return false;
    }
}
