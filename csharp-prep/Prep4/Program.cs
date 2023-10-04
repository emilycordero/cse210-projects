using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();
        while (number != 0) 
        {
            Console.WriteLine("Enter number: ");
            string usernumber = Console.ReadLine();
            number = int.Parse(usernumber);
            if (number != 0)
            {            
                numbers.Add(number);
            }
        } 
        foreach (int number1 in numbers)
        {
            total += number1;
        }
        Console.WriteLine($"Total: {total}");
        average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        foreach (int number1 in numbers)
        {
            if (number1 > max)
            {
                max = number1;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}