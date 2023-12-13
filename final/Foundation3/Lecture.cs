using System;

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string speakerName, int capacity, string eventName, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    public Lecture(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string speakerName, int capacity) : base(eventName, eventDescription, eventCategory, eventDate, eventTime, eventAddress) 
    {
        this.speakerName = speakerName;
        this.capacity = capacity;

    }

    public override string GenerateFullDetails()
    {
    return "Join us at " + eventName + " on " + eventDate + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateFullDetails()
    {
    return "Join us at " + eventName + " on " + eventDate + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateShortDescription()
    {
    return "Join us at " + EventName + " on " + EventDate + " for a " + EventCategory + ".";
    }
}