using System;

public class ChecklistGoal : Goal
{
    private double _checklistgoal;

    public ChecklistGoal(string goal, double checklistgoal) : base(goal)
    {
        _checklistgoal = checklistgoal;
    }

    public override double GetGoals()
    {
        return _checklistgoal;
    }
}
