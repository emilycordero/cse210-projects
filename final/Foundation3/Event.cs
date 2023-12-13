using System;

public class Event
{
    private string eventName;
    private string eventDescription;
    private string eventCategory;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public Event(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDescription = eventDescription;
        this.eventCategory = eventCategory;
        this.eventTime = eventTime;
        this.eventDate = eventDate;
        this.eventAddress = eventAddress;
    }


    public string EventName => eventName;
    public string EventDescription => eventDescription;
    public DateTime EventDate => eventDate;
    public TimeSpan EventTime => eventTime;
    public string EventAddress => eventAddress.GetFullAddress();
    public string EventCategory => eventCategory;

    public string GenerateStandardDetails()
    {
        return "Join us at " + eventName + " on " + eventDate.ToShortDateString() + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateFullDetails()
    {
        return "Join us at " + eventName + " on " + eventDate.ToShortDateString() + " at " + eventTime + ". We will be meeting in " + eventAddress + " for " + eventDescription + ".";
    }

    public virtual string GenerateShortDescription()
    {
        return "Join us at " + eventName + " on " + eventDate.ToShortDateString() + " for a " + eventCategory + ".";
    }
}