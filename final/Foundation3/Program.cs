using System;

class program
{
    static void Main(string[] args)
    {
        // Address for event 1
        Address address1 = new Address("1234 S Main St", "Othello", "WA", "USA");
        Lecture lectureEvent = new Lecture("C# Lecture", "In this lecture, we discuss the 4 main priciples: Abstraction, Encapsulation, Inheritance, and Polymorphism.", "Lecture", DateTime.Parse("12/18/2023"), TimeSpan.Parse("12:00"), address1, "Emily Cordero", 100);

        // Address for event 2
        Address address2 = new Address("1234 S Main St", "Seattle", "WA", "USA");
        Reception receptionEvent = new Reception("C# Lecture", "In this lecture, we discuss the 4 main priciples: Abstraction, Encapsulation, Inheritance, and Polymorphism.", "Lecture", DateTime.Parse("12/18/2023"), TimeSpan.Parse("12:00"), address2, "rsvp@receptionevent.com");

        // Address for event 3
        Address address3 = new Address("1234 S Main St", "Tokyo", "Tokyo", "Japan");
        OutdoorGathering outdoorGathering = new OutdoorGathering("C# Lecture", "In this lecture, we discuss the 4 main priciples: Abstraction, Encapsulation, Inheritance, and Polymorphism.", "Lecture", DateTime.Parse("12/18/2023"), TimeSpan.Parse("12:00"), address3, "Weather will be clear!");

        // Methods to generate the messages for lecture
        string lectureStandardDetails = lectureEvent.GenerateStandardDetails();
        string lectureFullDetails = lectureEvent.GenerateFullDetails();
        string lectureShortDetails = lectureEvent.GenerateShortDescription();
        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine(lectureShortDetails);

        // Methods to generate the messages for reception
        string receptionStandardDetails = receptionEvent.GenerateStandardDetails();
        string receptionFullDetails = receptionEvent.GenerateFullDetails();
        string receptionShortDetails = receptionEvent.GenerateShortDescription();
        Console.WriteLine(receptionStandardDetails);
        Console.WriteLine(receptionFullDetails);
        Console.WriteLine(receptionShortDetails);

        // Methods to generate the messages for Outdoor
        string outdoorGatheringStandardDetails = outdoorGathering.GenerateStandardDetails();
        string outdoorGatheringFullDetails = outdoorGathering.GenerateFullDetails();
        string outdoorGatheringShortDetails = outdoorGathering.GenerateShortDescription();
        Console.WriteLine(outdoorGatheringStandardDetails);
        Console.WriteLine(outdoorGatheringFullDetails);
        Console.WriteLine(outdoorGatheringShortDetails);
    }
}