
public class Person
{
    protected string _name;
    protected string _lastName;
    protected string _idCase;

    public Person()
    {
        _name = "";
        _lastName = "";
        _idCase = "";
    }

    public Person(string name, string lastName, string idCase)
    {
        _name = name;
        _lastName = lastName;
        _idCase = idCase;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetLastName()
    {
        return _lastName;
    }

    public void SetIdCase(string idCase)
    {
        _idCase = idCase;
    }

    public string GetIdCase()
    {
        return _idCase;
    }

    public virtual string ShowDataString()
    {
        return $"{_name} {_lastName} - {_idCase}";
    }

    public virtual string GetStringRepresentation()
    {
        Type type = GetType();
        return $"{type}:{_name},{_lastName},{_idCase}";
    }

    public virtual void AskData()
    {
        Console.WriteLine("Enter your first name:");
        _name = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        _lastName = Console.ReadLine();
    }
}