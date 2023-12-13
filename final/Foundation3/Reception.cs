using System;

public class Reception : Event
{
    private string email;

    public Reception(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string email) : base(eventName, eventDescription, eventCategory, eventDate, eventTime, eventAddress)
    {
        this.email = email;
    }


    public virtual string GenerateFullDetails()
    {
        return "Join us at " + EventName + " on " + EventDate.ToShortDateString() + " at " + EventTime + " for a " + EventCategory + ". We will be meeting in " + EventAddress + " for " + EventDescription + ". You must RSVP 3 days before by sending your information to this email: " + email;
    }

    public virtual string GenerateShortDescription()
    {
        return "Join us at " + EventName + " on " + EventDate.ToShortDateString() + " for a " + EventCategory + ".";
    }
}