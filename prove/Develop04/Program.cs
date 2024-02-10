using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";
        
        do
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu:");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice =="3")
            {
                if(choice == "1")
                {
                    Console.Clear();
                    BreathingActivity activity = new BreathingActivity();
                    activity.Run();
                }
                else if(choice == "2")
                {
                    Console.Clear();
                    ReflectingActivity activity = new ReflectingActivity();
                    activity.Run();
                }
                else
                {
                    Console.Clear();
                    ListingActivity activity3 = new ListingActivity();
                    activity3.Run();
                }
            }
            else if(choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for use this program, see you soon!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please, choose a valid option");
                Thread.Sleep(1000);
            }

        } while (choice != "4");
    }
}