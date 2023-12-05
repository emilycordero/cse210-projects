using System;
using System.IO;
using System.ComponentModel.Design;
using System.Threading;
using System.Xml.Linq;
class Program
{
    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Start goal activity\n5. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivityClass breathingActivityClass = new BreathingActivityClass();
                    Console.WriteLine();
                    break;
                case "2":
                    ReflectingActivityClass reflectingActivityClass = new ReflectingActivityClass();
                    Console.WriteLine();
                    break;
                case "3":
                    ListingActivityClass listingActivityClass = new ListingActivityClass();
                    Console.WriteLine();
                    break;
                case "4":
                    GoalActivityClass goalActivityClass = new GoalActivityClass();
                    Console.WriteLine();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid.");
                    break;
            }

            Thread.Sleep(3000); // Pause for 3 seconds before returning to the main menu
        }
        
    }
}
    