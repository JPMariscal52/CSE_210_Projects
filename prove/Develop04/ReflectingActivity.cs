
public class ReflectingActivity : Activity
{
    private List<String> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult",
        "Think of a time when you stood up for someone else",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
        "Think about the last time that you felt the influence of the holy spirit"
    };
    private List<String> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");

        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptRandomIndex = random.Next(_prompts.Count);

        return _prompts[promptRandomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionRandomIndex = random.Next(_questions.Count);

        return _questions[questionRandomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}  ");
    }
    
}