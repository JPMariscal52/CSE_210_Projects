using System.Linq.Expressions;

public class MaintenanceManager
{
    private List<Building> _ldsBuildings = new List<Building>();

    private List<Person> _leaders = new List<Person>();

    private List<Person> _technicians = new List<Person>();

    public MaintenanceManager()
    {

    }

    public void AssignService()
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to assign a technician (yes/no)?");
        string answer = Console.ReadLine();
        if(answer == "yes")
        {
            Console.WriteLine("Which service do you want to assign? ");
            Console.WriteLine("Enter the maintenance request number (1,2,3...):");
            int indexGoal = int.Parse(Console.ReadLine());
            Console.WriteLine("Assign an ID for this case (Ex. 486): ");
            string id = Console.ReadLine();

            for(int i = 0; i < _leaders.Count; i++)
            {
                if(i == indexGoal-1)
                {
                    Technician technician = new Technician();
                    technician.SetIdCase(id);
                    technician.AskData();
                    _technicians.Add(technician);

                    _leaders[i].SetIdCase(id);
                    _ldsBuildings[i].SetIdCase(id); 
                }
            }
        }
    }

    public void DisplayLeaderRequests()
    {
        Console.WriteLine("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"Hello President {firstName} {lastName}, these are your maintenance requests:");
        Console.WriteLine();

        for(int i = 0; i < _leaders.Count; i++)
        {
            if(firstName == _leaders[i].GetName() && lastName == _leaders[i].GetLastName() && _ldsBuildings[i].GetIsCompleteL() == false)
            {
                Console.WriteLine($"   [ ] - {_ldsBuildings[i].ShowDataString()}");   
            }
            else if(firstName == _leaders[i].GetName() && lastName == _leaders[i].GetLastName() && _ldsBuildings[i].GetIsCompleteL() == true)
            {
                Console.WriteLine($"   [X] - {_ldsBuildings[i].ShowDataString()}");   
            } 
        }
    }

    public void DisplayTechnicianRequests()
    {
        Console.Clear();

        Console.WriteLine("What is your first name? ");
        string firstName = (Console.ReadLine());
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        int number = 1;

        Console.Clear();

        Console.WriteLine($"Hello {firstName} {lastName}, your requests are:");
        Console.WriteLine();
        
        foreach(Person tech in _technicians)
        {
            if(firstName == tech.GetName() && lastName == tech.GetLastName())
            {
                Console.WriteLine($"{number}. {tech.ShowDataString()}");
                number++;
            } 
        }
    }

    public void RecordTechnicianServices()
    {
        Console.WriteLine();
        Console.WriteLine("Which maintenance request do you want to review?");
        Console.WriteLine("Enter the ID:");
        string request = Console.ReadLine();
        Console.WriteLine();

        for(int i = 0; i < _leaders.Count; i++)
        {
            if(request == _ldsBuildings[i].GetIdCase())
            {
                string check = " ";

                if(_ldsBuildings[i].GetIsCompleteT() == true)
                {
                    check = "X";
                }

                Console.WriteLine($"   {_leaders[i].ShowDataString()}");
                Console.WriteLine($"   {_ldsBuildings[i].ShowDataString()}");
                Console.WriteLine($"   Validation [{check}]");
                Console.WriteLine();

                Console.WriteLine("Do you want to record this maintenance request (yes/no)?");
                request = Console.ReadLine();

                if(request == "yes")
                {
                    _ldsBuildings[i].SetIsCompleteT(true);
                }
            }
            
            
        }
    }


    public void AskService(string option)
    {
        string calling = option;

        if(calling == "1")
        {
            TemplePresident templePresident = new TemplePresident();
            Temple temple = new Temple();
            Console.WriteLine("Welcome Temple President, enter your request: ");
            Console.WriteLine();
            templePresident.AskData();
            temple.AskData();

            _leaders.Add(templePresident);
            _ldsBuildings.Add(temple); 
        }
        else if(calling == "2")
        {
            StakePresident stakePresident = new StakePresident();
            Church church = new Church();
            Console.WriteLine("Welcome Stake President, enter your request:");
            Console.WriteLine();
            stakePresident.AskData();
            church.AskData();

            _leaders.Add(stakePresident);
            _ldsBuildings.Add(church);
        }

    }

    public void ShowServiceString()
    {
        Console.WriteLine("The required service are: ");
        Console.WriteLine();

        for(int i = 0; i < _leaders.Count; i++)
        {
            string valLeader = " ";
            string valTech = " ";

            if(_ldsBuildings[i].GetIsCompleteL() == true && _ldsBuildings[i].GetIsCompleteT() == false)
            {
                valLeader = "X";
            }
            else if(_ldsBuildings[i].GetIsCompleteL() == false && _ldsBuildings[i].GetIsCompleteT() == true)
            {
                valTech = "X";
            }
            else if(_ldsBuildings[i].GetIsCompleteL() == true && _ldsBuildings[i].GetIsCompleteT() == true)
            {
                valLeader = "X";
                valTech = "X";
            }

            Console.WriteLine($"{i+1}. {_leaders[i].ShowDataString()}");
            Console.WriteLine($"   {_ldsBuildings[i].ShowDataString()}");
            Console.WriteLine($"   Validation Leader [{valLeader}] Validation Technician [{valTech}]");
            Console.WriteLine();
        }
    }

    public void SaveServices()
    {
        Console.Clear();

        Console.WriteLine("What is the file name for the maintenance system data? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("This is all data from Maintenance Management System");

            foreach(Person leader in _leaders)
            {
                outputFile.WriteLine($"{leader.GetStringRepresentation()}");
            }

            foreach(Building building in _ldsBuildings)
            {
                outputFile.WriteLine($"{building.GetStringRepresentation()}");
            }

            foreach(Person technician in _technicians)
            {
                outputFile.WriteLine($"{technician.GetStringRepresentation()}");
            }
        }

    }

    public void LoadServices()
    {
        if (_leaders.Count == 0)
        {
            Console.WriteLine("What is the file name for the maintenance system data? ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName).Skip(1).ToArray();;

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ':', ',' });

                string goalType = parts[0];
                    
                    if(goalType == "TemplePresident")
                    {
                        string name = parts[1];
                        string lastName = parts[2];
                        string idCase = parts[3];

                        TemplePresident templePresident = new TemplePresident(name, lastName, idCase);
                        _leaders.Add(templePresident);
                    }
                    else if(goalType == "StakePresident")
                    {
                        string name = parts[1];
                        string lastName = parts[2];
                        string idCase = parts[3];
                        string stake = parts[4];

                        StakePresident stakePresident = new StakePresident(name, lastName, idCase, stake);
                        _leaders.Add(stakePresident);
                    }
                    else if(goalType == "Temple")
                    {
                        string city = parts[1];
                        string state = parts[2];
                        string description = parts[3];
                        bool isCompleteLeader = bool.Parse(parts[4]);
                        bool isCompleteTech = bool.Parse(parts[5]);
                        string idCase = parts[6];

                        Temple temple = new Temple(city, state, description, isCompleteLeader, isCompleteTech, idCase);
                        _ldsBuildings.Add(temple);
                    }
                    else if(goalType == "Church")
                    {
                        string city = parts[1];
                        string state = parts[2];
                        string description = parts[3];
                        bool isCompleteLeader = bool.Parse(parts[4]);
                        bool isCompleteTech = bool.Parse(parts[5]);
                        string idCase = parts[6];
                        string ward = parts[7];

                        Church church = new Church(city, state, description, isCompleteLeader, isCompleteTech, idCase, ward);
                        _ldsBuildings.Add(church);
                    }
                    else
                    {
                        string name = parts[1];
                        string lastName = parts[2];
                        string idCase = parts[3];
                        string speciality = parts[4];

                        Technician technician = new Technician(name, lastName, idCase, speciality);
                        _technicians.Add(technician);
                    
                    }
            }

        }
        else 
        {
            Console.WriteLine("You already have loaded a file");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            ConsoleKeyInfo key = Console.ReadKey();
        }
    }

    public void ListTechnicians()
    {
        Console.Clear();
        Console.WriteLine("These are all maintenance requests and technicians assigned:");
        Console.WriteLine();
        int number = 1;

        foreach(Person technician in _technicians)
        {
            Console.WriteLine($"{number}. {technician.GetName()} {technician.GetLastName()} - {technician.ShowDataString()} ");
            number++;
        }
    }

    public void RecordLeaderServices()
    {
        Console.WriteLine();
        Console.WriteLine("Do you want to record a service (yes/no)?");
        string answer = Console.ReadLine();
        Console.WriteLine();
        if(answer.ToLower() == "yes")
        {
            Console.WriteLine("Enter the ID service that you want to record");
            string id = Console.ReadLine();

            if(id != "")
            {
                for(int i = 0; i < _leaders.Count; i++)
                {
                    if(id == _ldsBuildings[i].GetIdCase())
                    {
                        _ldsBuildings[i].SetIsCompleteL(true);   
                    }
                }
            }
        }
        
    }

    public void ValidationMessage()
    {
        Console.Clear();
        Console.WriteLine("Please, choose a valid option");
        Thread.Sleep(2000);
    }

}