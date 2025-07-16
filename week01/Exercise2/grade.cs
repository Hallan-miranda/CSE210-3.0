public class Grade
{
    public string _letterGrade;
    public int _score;

    public int Grading(int score)
    {
        _score = score;

        if (_score >= 90)
        {
            _letterGrade = "A";
        }
        else if (_score >= 80)
        {
            _letterGrade = "B";
        }
        else if (_score >= 70)
        {
            _letterGrade = "C";
        }
        else if (_score >= 60)
        {
            _letterGrade = "D";
        }
        else
        {
            _letterGrade = "F";
        }

        return _score;
    }

    public void Display()
    {
        Console.WriteLine($"Your score is: {_score} and your letter grade is: {_letterGrade}");
    }
}