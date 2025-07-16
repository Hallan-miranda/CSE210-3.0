using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Name name = new Name();
        name.setFirstName(firstName);
        name.setlastName(lastName);
        name.Display();
    }
}