using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("John Doe", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(math.GetSummary());           // John Doe - Fractions
        Console.WriteLine(math.GetHomeworkList());      // Section 7.3 Problems 3-10, 20-21

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());        // Mary Waters - European History
        Console.WriteLine(writing.GetWritingInformation()); // The Causes of World War II by Mary Waters
    }
}