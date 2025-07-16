using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static  string PromptUserName()
        {
            Console.Write("Please enter your name: ");
             string name = Console.ReadLine();

            return name;

        }
        static  string PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
             string number = Console.ReadLine();

             return number;
        } 
        static  int SquareNumber(string value)
        {

            int squareNumber = int.Parse(value);
            int square = squareNumber * squareNumber;

            return square;
        }
        void DisplayResult(){

            DisplayWelcome();
            string name = PromptUserName();
            string number = PromptUserNumber();
            int Square = SquareNumber(number);

            Console.WriteLine($"Brother {name}, the square of your number is {Square}");

        } 

        DisplayResult();
    
    }
}