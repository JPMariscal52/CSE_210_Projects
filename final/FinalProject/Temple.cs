
public class Temple:Building
{
    public Temple()
    {

    }

    public Temple(string city, string state, string description, bool isCompleteLeader, bool isCompleteTech, string idCase):base(city,state,description,isCompleteLeader,isCompleteTech,idCase)
    {
        _city = city;
        _state = state;
        _description = description;
        _isCompleteLeader = isCompleteLeader; 
        _isCompleteTech = isCompleteTech;
        _idCase = idCase;
    }

    public override string ShowDataString()
    {
        return $"Temple: {_city} - State: {_state} \n   Description: {_description} \n   Request ID: {_idCase}";
    }

    public override void AskData()
    {
        base.AskData();
    }

}