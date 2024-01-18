using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Maintenance Technician";
        job1._company = "ORC";
        job1._startYear = 2017;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Process Technician";
        job2._company = "Corning";
        job2._startYear = 2017;
        job2._endYear = 2022;

        Resume resume = new Resume();

        resume._name = "Jose Pablo";
        resume._jobList = new List<Job>();

        resume._jobList.Add(job1);
        resume._jobList.Add(job2);

        resume.DisplayMyResume();
    }
}