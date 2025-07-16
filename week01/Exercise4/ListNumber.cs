public class ListNumber
{
    public List<int> _numbers;
    public int _sum;
    public int _avarege;
    public int _largest;
    public int _smallest;
    public List<int> _sorted;

    public void List(List<int> numbers)
    {
        _numbers = numbers;
    }

    public void Calculate()
    {
        _sum = 0;
        _largest = int.MinValue;
        _smallest = int.MaxValue;

        foreach (int number in _numbers)
        {
            _sum += number;
            if (number > _largest)
            {
                _largest = number;
            }
            if (number < _smallest && number > 0)
            {
                _smallest = number;
            }
        }

        _avarege = _sum / _numbers.Count;
        _sorted = new List<int>(_numbers);
        _sorted.Sort();
    }

    public void Display()
    {
        Console.WriteLine($"The Sum: {_sum}");
        Console.WriteLine($"The Average: {_avarege:f3}");
        Console.WriteLine($"The Largest: {_largest}");
        Console.WriteLine($"The Smallest: {_smallest}");
        Console.WriteLine("The Sorted List: " + string.Join(", ", _sorted));
    }
}