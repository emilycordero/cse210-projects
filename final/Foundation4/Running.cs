using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double distance;

    public Running(string name, double duration, double distance) : base(name, duration)
    {
        this.distance = distance;
    } 

    public override double GetDistance()
    {
        return distance * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (distance / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + "\nDistance: " + distance + " miles" + "\nSpeed: " + GetSpeed() + " mph" + "\nPace: " + GetPace() + " min/mile";
    }

}