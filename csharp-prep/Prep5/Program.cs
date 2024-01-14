using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        int sqrNumber = SquareNumber(number);
        DisplayResult(name, sqrNumber);

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static String PromptUserName()
        {
            Console.Write("Please enter your name:");
            String userName = Console.ReadLine();
            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

    static int SquareNumber(int number)
       {
           int squareNumber = number * number;
           return squareNumber;
       }

    static void DisplayResult(String name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }


    
}