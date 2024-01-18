public class Resume
{
    public string _name;
    public List<Job> _jobList;

    public void DisplayMyResume()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
    }
}