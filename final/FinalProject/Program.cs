using System;

class Program
{
    static void Main(string[] args)
    {
        
        string option = "";

        do
        {
            Console.WriteLine("Welcome to the Church Maintenance Manangement System");

            Console.WriteLine("1. Facilities supervisor");
            Console.WriteLine("2. Church leader");
            Console.WriteLine("3. Facilities Technician");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Please select your charge: ");
            option = Console.ReadLine();

        } while (option != "4");



    }
}