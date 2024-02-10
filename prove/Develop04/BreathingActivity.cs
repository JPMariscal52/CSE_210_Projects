
public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your brething";
        _duration = 0;

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
        Console.Write($"Breathe in ...");
        ShowCountDown(3);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < futureTime)
        {
                Console.WriteLine();   
                Console.Write($"Breathe in ...");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                ShowCountDown(6);
                Console.WriteLine();
            
        }

        Console.WriteLine();
        DisplayEndingMessage();        

    }
}