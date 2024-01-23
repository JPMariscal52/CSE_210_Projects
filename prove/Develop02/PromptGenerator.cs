public class PromptGenerator
{
    public List<String> _promptList = new List<string>
    {
        "What was your spiritual experience today?",
        "What was the good act that you could do for someone today?",
        "What was the best part of my day?",
        "What did you eat for breakfast today?",
        "What was something useful did you learn today?",
        "What am I grateful for today?",
        "What challenge did I overcome today?",
        "Tell me a funny experience that you have had today",
        "How did I see the hand of the Lord in my life today?",
        "How did you solve a problem today?"
    };

     public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);

        return _promptList[index];
    }
}

