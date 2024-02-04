using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment1 = new Assignment("Juan Carlos", "Ecuations");
        string summary = assigment1.GetSummary();

        MathAssignment mAssignment = new MathAssignment("4.5", "1-10","Tania Rodriguez", "Addition");
        string mSummary = mAssignment.GetSummary();
        string mHomeWorkList = mAssignment.GetHomeworkList();

        WritingAssignment wAssignment = new WritingAssignment("Good behavior", "Jafet Muñiz", "Human Nature");
        string wSummary = wAssignment.GetSummary();
        string wInformation = wAssignment.GetWritingInformation();


        Console.WriteLine(summary);
        Console.WriteLine(mSummary);
        Console.WriteLine(mHomeWorkList);
        Console.WriteLine(wSummary);
        Console.WriteLine(wInformation);

    }
}