using System.IO;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    

    public void AddEntry()
    {

        Entry newEntry = new Entry();
        PromptGenerator generator = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._promptDate = theCurrentTime.ToShortDateString();

        newEntry._promptQuestionText = generator.GetRandomQuestion();

        Console.WriteLine(newEntry._promptQuestionText);
        newEntry._promptAnswerText = Console.ReadLine();

        _entryList.Add(newEntry);
        
        
    }

    public void DisplayAll()
    {

        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();

        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entryList)
        {
            outputFile.WriteLine($"{entry._promptQuestionText},{entry._promptAnswerText},{entry._promptDate}");

        }
        }
    }

    public void LoadToFile()
    {
        
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();

            newEntry._promptQuestionText = parts[0];
            newEntry._promptAnswerText = parts[1];
            newEntry._promptDate = parts[2];
    
            _entryList.Add(newEntry);
            
        }
    }
}

