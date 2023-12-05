using System;

public class SimpleGoal : Goal
{
    private double _simplegoal;

    public SimpleGoal(string goal, double simplegoal) : base(goal)
    {
        _simplegoal = simplegoal;
    }

    public override double GetGoals()
    {
        return _simplegoal;
    }
}
