
public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        List<string> userPrompts = GetListFromUser();

        _count = 0;
        while(DateTime.Now < futureTime)
        {
            
            Console.Write(">");
            string input = Console.ReadLine();
            userPrompts.Add(input);

            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");

        Console.WriteLine();
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int promptRandomIndex = random.Next(_prompts.Count);

        string textPrompt =_prompts[promptRandomIndex];

        Console.WriteLine($"--- {textPrompt} ---");

    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}