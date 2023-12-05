using System;

public class EternalGoal : Goal
{
	private double _eternalgoal;

	public EternalGoal(string goal, double eternalgoal) : base (goal)
	{
		_eternalgoal = eternalgoal;
	}

	public override double GetGoals()
	{ 
		return _eternalgoal; 
	}
}
