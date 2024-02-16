
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amount, bool complete) : base(name, description, points, complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
        _isComplete = complete;
    }


    public override int GetPoints()
    {
        return _points + _bonus;
    }

    public override void RecordEvent()
    {   
        if(_amountCompleted == _target-1)
        {
           _isComplete = true;
           Console.WriteLine($"Congratulations! You have earned {_points + _bonus}"); 
        }
        else
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string check = "[ ]";
        
        if (_isComplete == true)
        {
            check = "[X]";
            _amountCompleted = _target;
        }

        return $"{check} {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        Type type = GetType();
        return $"{type}:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted},{_isComplete}";
    }
}