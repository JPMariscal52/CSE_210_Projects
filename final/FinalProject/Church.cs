

public class Church:Building
{

    private string _ward;
    public Church()
    {
        _ward = "";
    }

    public Church(string city, string state, string description, bool isCompleteLeader, bool isCompleteTech, string idCase, string ward):base(city,state,description,isCompleteLeader,isCompleteTech,idCase)
    {
        _city = city;
        _state = state;
        _description = description;
        _isCompleteLeader = isCompleteLeader; 
        _isCompleteTech = isCompleteTech;
        _idCase = idCase;
        _ward = ward;
    }

    public override string ShowDataString()
    {
        return $"Church: {_ward} ward \n   City: {_city} - State: {_state} \n   Description: {_description} \n   Request ID: {_idCase}"; 
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation()+$",{_ward}";
    }

    public override void AskData()
    {
        Console.WriteLine("What is the ward name?");
        _ward = Console.ReadLine();
        base.AskData();
    }
}