
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;

    }

    public Goal(string name, string description, int points, bool complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;

    }

    public virtual string GetName()
    {
        return _shortName;
    }

    public virtual int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        if(_isComplete == false)
        {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        string check = "[ ]";
        
        if (_isComplete == true)
        {
            check = "[X]";
        }

        return $"{check} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        Type type = GetType();
        return $"{type}:{_shortName},{_description},{_points},{_isComplete}";
    }
}