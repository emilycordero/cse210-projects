using System;

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string speakerName, int capacity, string eventName, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GenerateFullDetails()
    {
    return $"Our speaker will be: {speakerName} and our capacity is {capacity}";
    }

    public override string GenerateShortDescription()
    {
    return "Join us at " + eventName + " on " + eventDate + " for a " + eventCategory + ".";
    }
}