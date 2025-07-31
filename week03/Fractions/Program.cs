using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);    
        Fraction fraction3 = new Fraction(3, 4);    
        Fraction fraction4 = new Fraction(1, 3);    


        fraction1.Display();
        Console.WriteLine(fraction1.GetDecimalValue());
        fraction2.Display();
        Console.WriteLine(fraction2.GetDecimalValue());
        fraction3.Display();
        Console.WriteLine(fraction3.GetDecimalValue());
        fraction4.Display();
        Console.WriteLine(fraction4.GetDecimalValue());

    }
    public class Fraction
    {
        private int top;
        private int botton;

        public Fraction()
        {
            top = 1;
            botton = 1;
        }

        public Fraction(int top)
        {
            this.top = top;
            this.botton = 1;
        }

        public Fraction(int top, int botton)
        {
            this.top = top;
            this.botton = botton;
        }

        public int Gettop()
        {
            return top;
        }

        public void Settop(int top)
        {
            this.top = top;
        }

        public int Getbotton()
        {
            return botton;
        }

        public void Setbotton(int botton)
        {
            this.botton = botton;
        }

        public string GetFractionString()
        {
            return $"{top}/{botton}";
        }

        public double GetDecimalValue()
        {
            return (double)top / botton;
        }

        public void Display()
        {
            Console.WriteLine($"{top}/{botton}");
        }
    }
}
