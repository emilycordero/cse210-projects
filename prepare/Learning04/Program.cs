using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    }
}
/* Notes:
 // a reg class called Person
public class Person 
{
    public string GetName()
    {
        return "Joseph";
    }
}
// a class that inherits from Person
public class Student : Person
{
    public string GetNumber()
    {
        return "0123456789";
    }
}

// main program.cs
Student studen = new Student();
string name = student.GetName();
console.Writeline(name);

// Super and base
public classPerson
{
    private string _name;
    public Person(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

}
public class Student : Person
{
    private string _number;
    // calling the parent constructor using "base"
    public Student(string name, string number) : base(name)
    {
        _number = number;
    }
    public string GetNumber()
    {
        return _number;
    }
    public string GetStudentInfo()
    {
        return _name + " " + _number;
    }
}
// main program
Student student = new Student("BYUI", "123");
string name = base.GetName();
string number = base.GetNumber();
Console.WriteLine($"Student Number: {number}");

 */