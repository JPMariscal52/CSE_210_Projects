using System.IO;
using System.Threading.Tasks.Dataflow;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string choice = "";

        do
        {
            Console.Clear();

            DisplayPlayerInfo();
            StartMenu();
            choice = Console.ReadLine();


            if( choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
            {
                if (choice == "1")
                {
                    Console.Clear();
                    CreateGoal();
                }
                else if(choice == "2")
                {
                    Console.Clear();
                    ListGoalDetails();

                }
                else if(choice == "3")
                {
                    SaveGoals();
                }
                else if(choice == "4")
                {
                    LoadGoals();
                }
                else
                {
                    Console.Clear();
                    ListGoalNames();
                    RecordEvent();
                }
            }
            else
            {
                Console.WriteLine("Please, choose a valid option");
            }
            

        } while (choice != "6");
    }

    public void DisplayPlayerInfo()
    {
        _score = 0;
        foreach(Goal goal in _goals)
        {
            bool isComplete = goal.IsComplete();
            if(isComplete == true)
            {
                int score = goal.GetPoints();
                _score += score;
            }

        }
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void StartMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine();
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
        Console.WriteLine("Select a choice from the menu:");
        
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        Console.WriteLine();

        int goalNumber = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. " + goal.GetName());
            goalNumber++;
        }

    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        Console.WriteLine();

        int goalNumber = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. " + goal.GetDetailsString());
            goalNumber++;
        }

        Console.WriteLine();
        Console.WriteLine("Press enter to continue.");
        ConsoleKeyInfo key = Console.ReadKey();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.WriteLine("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        if (goalChoice == "1" || goalChoice == "2" || goalChoice == "3")
        {
            if(goalChoice == "1")
            {

                Console.WriteLine("What is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int goalPoints = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);

                _goals.Add(simpleGoal);
            }
            else if(goalChoice == "2")
            {

                Console.WriteLine("What is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int goalPoints = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);

                _goals.Add(eternalGoal);
            }
            else
            {

                Console.WriteLine("What is the name of your goal?");
                string goalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int goalPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);

                _goals.Add(checklistGoal);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid option");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            ConsoleKeyInfo key = Console.ReadKey();
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        int indexGoal = int.Parse(Console.ReadLine());
        int i = 1;

        foreach(Goal goal in _goals)
        {
            if(i == indexGoal)
            {
                goal.RecordEvent();
            }

        i++;

        }

        Console.WriteLine();
        Console.WriteLine("Press enter to continue.");
        ConsoleKeyInfo key = Console.ReadKey();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("What is the file name for the goal file? ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName).Skip(1).ToArray();;

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ':', ',' });

                string goalType = parts[0];
                    
                    if(goalType == "SimpleGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool complete = bool.Parse(parts[4]);

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points, complete);
                        _goals.Add(simpleGoal);
                    }
                    else if(goalType == "EternalGoal")
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        bool complete = bool.Parse(parts[4]);

                        EternalGoal eternalGoal = new EternalGoal(name, description, points, complete);
                        _goals.Add(eternalGoal);
                    }
                    else
                    {
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        int bonus = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int amount = int.Parse(parts[6]);
                        bool complete = bool.Parse(parts[7]);

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amount, complete);
                        _goals.Add(checklistGoal);
                    
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
}