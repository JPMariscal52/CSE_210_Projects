using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 21);

        int response = 0;

        while (response != number)
        {
            
            Console.WriteLine("What is the magic number?");
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());

            if (response > number)
            {
                Console.WriteLine("Lower");
            }
            else if (response < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congratulations!");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}