
public class StakePresident:Person
{
    private string _stake;

    public StakePresident()
    {
        _stake = "";
    }

    public StakePresident(string name, string lastName, string idCase, string stake):base(name, lastName, idCase)
    {
        _name = name;
        _lastName = lastName;
        _idCase = idCase;
        _stake = stake;
    }

    public override string ShowDataString()
    {
        return $"Stake president: {_name} {_lastName} - Stake: {_stake}";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation()+$",{_stake}";
    }

    public override void AskData()
    {
        base.AskData();

        Console.WriteLine("What is the stake name?");
        _stake = Console.ReadLine();
        
    }

}