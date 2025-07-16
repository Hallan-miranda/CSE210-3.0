using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("what is your grade porcent?");
        int score = int.Parse(Console.ReadLine());
        Grade hallanGrade = new Grade();
        hallanGrade.Grading(score);
        hallanGrade.Display();
    }
}