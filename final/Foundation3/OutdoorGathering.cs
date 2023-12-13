using System;

public class OutdoorGathering : Event
{
	private string weatherState;
	public OutdoorGathering(string eventName, string eventDescription, string eventCategory, DateTime eventDate, TimeSpan eventTime, Address eventAddress, string weatherState) : base(eventName, eventDescription, eventCategory, eventDate, eventTime, eventAddress)
	{
		this.weatherState = weatherState;
	}

	public string GenerateStandardDetails()
	{
		return "Join us at " + EventName + " on " + EventDate + " at " + EventTime + ". We will be meeting in " + EventAddress + " for " + EventDescription + ".";
	}

	public virtual string GenerateFullDetails()
	{
		return "Join us at " + EventName + " on " + EventDate + " at " + EventTime + " for a " + EventCategory + ". We will be meeting in " + EventAddress + " for " + EventDescription + "." + weatherState + " Look forward to it!";
	}

	public virtual string GenerateShortDescription()
	{
		return "Join us at " + EventName + " on " + EventDate + " for a " + EventCategory + ".";
	}
}