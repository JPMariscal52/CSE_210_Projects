
public class TemplePresident:Person
{
    

    public TemplePresident()
    {

    }

    public TemplePresident(string name, string lastName, string idCase):base(name, lastName, idCase)
    {
        _name = name;
        _lastName = lastName;
        _idCase = idCase;
    }

    public override string ShowDataString()
    {
        return $"Temple president: {_name} {_lastName}";
    }


}