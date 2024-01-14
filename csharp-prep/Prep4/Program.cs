using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = 1;
        int total = 0;
        float average;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if(number > 0)
            {
                numbers.Add(number);
            }
            
        }

        int largest = numbers[0];

        foreach(int num in numbers)
        {
            total += num; 

             if (num > largest)
                {
                    largest = num;
                }
        }

        
        int numberOfElements = numbers.Count;
        average = (float)total/numberOfElements;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {largest}");

    }
}