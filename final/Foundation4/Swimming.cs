using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;

    public Swimming(string name, double duration, int laps) : base(name, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / duration) * 60;
    }

    public override double GetPace()
    {
        return duration / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + "\nLaps: " + laps + "\nDistance: " + distance + " miles" + "\nSpeed: " + GetSpeed() + " mph" + "\nPace: " + GetPace() + " min/mile";
    }

}