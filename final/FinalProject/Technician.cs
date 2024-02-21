
public class Technician:Person
{
    private string _speciality;

    public Technician()
    {
        _speciality = "";
    }

    public Technician(string name, string lastName, string idCase, string speciality):base(name, lastName, idCase)
    {
        _name = name;
        _lastName = lastName;
        _idCase = idCase;
        _speciality = speciality;
    }

    public override string ShowDataString()
    {
        return $"Speciality: {_speciality} - Request ID: {_idCase}";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation()+$",{_speciality}";
    }

    public override void AskData()
    {
        Console.WriteLine("Enter technician first name:");
        _name = Console.ReadLine();
        Console.WriteLine("Enter technician last name:");
        _lastName = Console.ReadLine();
        Console.WriteLine("Enter the type of maintenance:");
        Console.WriteLine("(Ex: electricity, plumbing, brickwork, construction, gardening, paint, equipment reparation)");
        _speciality = Console.ReadLine();
        
    }
}