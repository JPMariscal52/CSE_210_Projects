using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your first name?");
        String name = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        String lastname = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}");
        

    }
}