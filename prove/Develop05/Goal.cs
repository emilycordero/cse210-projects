using System;

public abstract class Goal
{
	private string _goal;

	public Goal(string goal)
	{
		_goal = goal;
	}

	public string GetGoal() 
	{ 
		return _goal; 
	}

	public void SetGoal(string goal)
	{
		_goal = goal;
	}

	public abstract double GetGoal();
}
