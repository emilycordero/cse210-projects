using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public abstract class Goal
{
    public string goalName { get; set; }
    public string goalDescription { get; set; }

    public int numberOfPoints { get; set; }


    public Goal(string goalName, string goalDescription, int numberOfPoints)
	{
        this.goalName = goalName;
        this.goalDescription = goalDescription; 
        this.numberOfPoints = numberOfPoints;

        
    }
    public abstract void RecordEvent();
    public abstract bool IsCompleted();
}