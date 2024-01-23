public class Entry
{
    public string _promptDate;
    public string _promptQuestionText;
    public string _promptAnswerText;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_promptDate} - Prompt: {_promptQuestionText}");
        Console.WriteLine($"{_promptAnswerText}");
        Console.WriteLine("");
    }

}