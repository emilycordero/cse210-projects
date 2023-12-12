using System;

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    class Lecture(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public string GenerateStandardDetails()
    {
    return "Join us at " + eventName + " on " + eventDate + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateFullDetails()
    {
    return "Join us at " + eventName + " on " + eventDate + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateShortDescription()
    {
    return "Join us at " + eventName + " on " + eventDate + " for a " + eventCategory + ".";
    }
}