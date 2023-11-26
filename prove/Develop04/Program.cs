using System;
using System.IO;
using System.ComponentModel.Design;
using System.Threading;
using System.Xml.Linq;
using static BreathingActivityClass;
using static ReflectingActivityClass;
using static ListingActivityClass;
using static GeneratePromptClass;
class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            var runActivity = new Program();

            switch (choice)
            {
                case "1":
                    RunActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                case "2":
                    RunActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;
                case "3":
                    RunActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }

    static void RunActivity(string name, string description)
    {

        switch (name)
        {
            case "Breathing":
                BreathingActivityClass breathingActivityClass = new BreathingActivityClass();
                break;
            case "Reflecting":
                ReflectingActivityClass reflectingActivityClass = new ReflectingActivityClass();
                break;
            case "Listing":
                ListingActivityClass listingActivityClass = new ListingActivityClass();
                break;
            default:
                Console.WriteLine("Invalid.");
                break;
        }

        Thread.Sleep(3000); // Pause for 3 seconds before returning to the main menu
    }
}
    