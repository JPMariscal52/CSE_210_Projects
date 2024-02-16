
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

     public EternalGoal(string name, string description, int points, bool complete) : base (name,description,points,complete)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = complete;
    }
   

}