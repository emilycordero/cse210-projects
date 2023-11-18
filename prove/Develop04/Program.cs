using System;
using System.IO;
using System.ComponentModel.Design;
// Consider an app that provides three different kinds of mindfulness opportunities. It could give some guidance and structure to users in the following activities:

//Breathing Activity - Help the user pace their breathing to have a session of deep breathing for a certain amount of time. They might find more peace and less stress through the exercise.
//Reflection Activity - Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength. Then, prompt them with questions to reflect more deeply about details of this experience. They might discover more depth than they previously realized.
//Listing Activity - Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivity. They might discover more breadth than they previously realized.
//The application could additional help the user keep track of the time or frequency they spend in these activities and give them gentle prompts and reminders.
class Program
{
    
    static void RunActivity(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"----- {name} Activity -----");
        Console.WriteLine(description);
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds before starting the activity

        Console.WriteLine("Activity in progress...");

        // Show animation while the activity is running
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Pause for 1 second
        }

        Console.WriteLine();
        Console.WriteLine("Good job!");

        Console.WriteLine($"You have completed the {name} activity for {duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds before returning to the main menu
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = GeneratePrompt();
                    RunActivity("ReflectingActivity", $"{prompt}");
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}