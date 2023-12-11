using System;

// This will be for inheriting the abstract class and to implement goals
public class ConcreteGoal : Goal
{
	public ConcreteGoal(string goalName, string goalDescription, int numberOfPoints, UserPoints UserPoints) : base(goalName, goalDescription, numberOfPoints)
    {
	}

    public override void RecordEvent()
    {

    }
    public override bool IsCompleted()
    {
        return false;
    }
}
