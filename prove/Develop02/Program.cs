using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (option > 0 || option < 6)
            {
                if (option == 1)
                {
                    journal.AddEntry();
                }
                else if (option == 2)
                {
                    journal.DisplayAll();
                }
                else if (option == 3)
                {
                    journal.LoadToFile();
                }
                else if (option == 4)
                {
                    journal.SaveToFile();
                }
             
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }



        }

        
        
    }
}