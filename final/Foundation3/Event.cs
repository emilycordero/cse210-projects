using System;

public class Event
{
    private string eventName;
    private string eventDescription;
    private string eventCategory;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    public Event(string eventName, string eventCategory, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDescription = eventDescription;
        this.eventCategory = eventCategory;
        this.eventTime = eventTime;
        this.eventDate = eventDate;
        this.eventAddress = eventAddress;
    }

    public Event(string eventName, string eventDescription, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDescription = eventDescription;
        this.eventDate = eventDate;
        this.eventTime = eventTime;
        this.eventAddress = eventAddress;
    }

    public string GetEventName()
    {
        return eventName;
    }
    public string GetEventDescription()
    {
        return eventDescription;
    }

    public DateTime GetEventDate()
    {
        return eventDate;
    }

    public TimeSpan GetEventTime()
    {
        return eventTime;
    }
    public string GetEventAddress()
    {
        return eventAddress.GetFullAddress();
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