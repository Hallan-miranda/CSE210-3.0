public class Name
{
    public string _firstName;
    public string _lastName;

    public string setFirstName(string firstName)
    {
        _firstName = firstName;
        return _firstName;
    }
    public string setlastName(string lastName)
    {
        _lastName = lastName;
        return _lastName;
    }

    public void Display()
    {
        Console.WriteLine($"Your name is: {_lastName}, {_firstName} {_lastName}");
    }
}