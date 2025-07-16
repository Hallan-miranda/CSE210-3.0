using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Number number = new Number();
        int randomNumber = number.SetNumber();
        Console.Write("What is the magic number?");
        guess = int.Parse(Console.ReadLine());

        while (randomNumber != guess)
        {
            if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
        }
    Console.Write("You guessed it!");
    }
                
            
}