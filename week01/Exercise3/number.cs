public class Number
{
    public int _num;
    public int _guess;

    public int SetNumber()
    {
        Random random = new Random();
        _num = random.Next(1, 100);
        return _num;
    }

    public void GuessNumber(int guess)
    {
        _guess = guess;

        if (_guess < _num)
        {
            Console.WriteLine("Lower");
        }
        else if (_guess > _num)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}

