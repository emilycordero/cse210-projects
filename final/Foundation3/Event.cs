using System;

public class Event
{
    private string eventName;
    private string eventDescription;
    private string eventCategory;
    private DateTime eventDate;
    private TimeSpan eventTime;
    private Address eventAddress;

    class Event(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress)
    {
        this.eventName = eventName;
        this.eventDescription = eventDescription;
        this.eventCategory = eventCategory;
        this.eventDate = eventDate;
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

    public string GetEventTime()
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