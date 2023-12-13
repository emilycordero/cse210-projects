using System;
using System.Collections.Generic;

public class Activity
{
    protected string name;
    protected double duration;

    public Activity(string name, double duration) 
    {
        this.name = name;
        this.duration = duration;   
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "Activity: " + name + "\nDuration: " + duration + " minutes";
    }

}