using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a Number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        ListNumber list = new ListNumber();
        list.List(numbers);
        list.Calculate();
        list.Display();
    }
}