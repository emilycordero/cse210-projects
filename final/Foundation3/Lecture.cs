using System;

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string speakerName, int capacity) : base(eventName, eventDescription, eventCategory, eventDate, eventTime, eventAddress) 
    {
        this.speakerName = speakerName;
        this.capacity = capacity;

    }
    
    public override string GenerateFullDetails()
    {
    return "Join us at " + EventName + " on " + EventDate.ToShortDateString() + " at " + EventTime + " for a " + EventCategory + ". We will be meeting in " + EventAddress + " for " + EventDescription + ". Speaking today will be: " + speakerName + ". Max capacity: " + capacity + " people.";
    
    }

    public virtual string GenerateShortDescription()
    {
    return "Join us at " + EventName + " on " + EventDate.ToShortDateString() + " for a " + EventCategory + ".";
    }
}