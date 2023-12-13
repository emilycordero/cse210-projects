using System;

class Program
{
    static void Main(string[] args)
    {
        // Address for event 1
        string dateString1 = "01/12/2024";
        DateTime parsedDate = DateTime.ParseExact(dateString1, "MM/dd/yyyy", null);

        Address address1 = new Address("1234 S Main St", "Othello", "WA", "USA");
        Lecture lectureEvent = new Lecture("C# Lecture", "In this lecture, we discuss the 4 main priciples: Abstraction, Encapsulation, Inheritance, and Polymorphism.", "Lecture", parsedDate, TimeSpan.Parse("14:00"), address1, "Emily Cordero", 100);

        // Address for event 2
        string dateString2 = "10/12/2024";
        DateTime parsedDate2 = DateTime.ParseExact(dateString2, "MM/dd/yyyy", null);
        Address address2 = new Address("1234 S Main St", "Seattle", "WA", "USA");
        Reception receptionEvent = new Reception("Wedding Reception", "We are going to be Mr. and Mrs. De Jesus and you are invited! RSVP ASAP.", "Reception", parsedDate2, TimeSpan.Parse("11:00"), address2, "rsvp@receptionevent.com");

        // Address for event 3
        string dateString3 = "04/21/2024";
        DateTime parsedDate3 = DateTime.ParseExact(dateString3, "MM/dd/yyyy", null);
        Address address3 = new Address("1234 S Main St", "Tokyo", "Tokyo", "Japan");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Shinjuku Gyoen National Garden", "Shinjuku Gyo-en is a large park and garden in Shinjuku and Shibuya, Tokyo, Japan. It was originally a residence of the Naito family in the Edo period.", "Outdoor Gathering", parsedDate3, TimeSpan.Parse("09:00"), address3, "Weather will be clear!");

        // Intro
        Console.WriteLine("Welcome to our company messaging system. Here is our messages for each event with each option.");
        // Methods to generate the messages for lecture
        string lectureStandardDetails = lectureEvent.GenerateStandardDetails();
        string lectureFullDetails = lectureEvent.GenerateFullDetails();
        string lectureShortDetails = lectureEvent.GenerateShortDescription();
        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine();
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine();
        Console.WriteLine(lectureShortDetails);
        Console.WriteLine();

        // Methods to generate the messages for reception
        string receptionStandardDetails = receptionEvent.GenerateStandardDetails();
        string receptionFullDetails = receptionEvent.GenerateFullDetails();
        string receptionShortDetails = receptionEvent.GenerateShortDescription();
        Console.WriteLine(receptionStandardDetails);
        Console.WriteLine();
        Console.WriteLine(receptionFullDetails);
        Console.WriteLine();
        Console.WriteLine(receptionShortDetails);
        Console.WriteLine();

        // Methods to generate the messages for Outdoor
        string outdoorGatheringStandardDetails = outdoorGathering.GenerateStandardDetails();
        string outdoorGatheringFullDetails = outdoorGathering.GenerateFullDetails();
        string outdoorGatheringShortDetails = outdoorGathering.GenerateShortDescription();
        Console.WriteLine(outdoorGatheringStandardDetails);
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringFullDetails);
        Console.WriteLine();
        Console.WriteLine(outdoorGatheringShortDetails);
        Console.WriteLine();
    }
}