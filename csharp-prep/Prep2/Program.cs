using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        String letter;
        Console.WriteLine("Enter your percentage:");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 0 && grade <= 100)
        {
            if (grade >= 90 && grade < 101)
            {
                letter = "A";
            }
            else if (grade >= 80 && grade < 90)
            {
                letter = "B";
            }
            else if (grade >= 70 && grade < 80)
            {
                letter = "C";
            }
            else if (grade >= 60 && grade < 70)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your note is {letter}.");

            if (letter == "A" || letter == "B" || letter == "C")
            {
                Console.WriteLine("Congratulations! You have approved the course!");
            }
            else
            {
                Console.WriteLine("Keep traying, you can do it!");
            }
        }
        else
        {
            Console.WriteLine("Please, enter a valid value.");
        }
        

        
    }
}