
public class Building
{
    protected string _city;
    protected string _state;
    protected string _description;
    protected bool _isCompleteLeader;
    protected bool _isCompleteTech;
    protected string _idCase;

    public Building()
    {
        _city = "";
        _state = "";
        _description = "";
        _isCompleteLeader = false; 
        _isCompleteTech = false;
        _idCase = "";
    }

    public Building(string city, string state, string description, bool isCompleteLeader, bool isCompleteTech, string idCase)
    {
        _city = city;
        _state = state;
        _description = description;
        _isCompleteLeader = isCompleteLeader; 
        _isCompleteTech = isCompleteTech;
        _idCase = idCase;
    }

    public void SetIdCase(string idCase)
    {
        _idCase = idCase;
    }

    public string GetIdCase()
    {
        return _idCase;
    }

    public void SetIsCompleteL(bool verify)
    {
        _isCompleteLeader = verify;
    }

    public bool GetIsCompleteL()
    {
        return _isCompleteLeader;
    }

    public void SetIsCompleteT(bool verify)
    {
        _isCompleteTech = verify;
    }

    public bool GetIsCompleteT()
    {
        return _isCompleteTech;
    }

    public virtual string ShowDataString()
    {
        return $"{_city}, {_state} - {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        Type type = GetType();
        return $"{type}:{_city},{_state},{_description},{_isCompleteLeader},{_isCompleteTech},{_idCase}";
    }

    public virtual void AskData()
    {
        Console.WriteLine("Enter the city where is located:");
        _city = Console.ReadLine();
        Console.WriteLine("Enter the state where is located:");
        _state = Console.ReadLine();
        Console.WriteLine("Enter a brief description of the case:");
        _description = Console.ReadLine();
        
    }

    

}
