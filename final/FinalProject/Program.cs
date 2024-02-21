using System;
using System.Formats.Asn1;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        MaintenanceManager maintenanceManager = new MaintenanceManager();
        string option = "";

        do
        {
            Console.Clear();

            //In this section you can select the profile that you will use.
            //If you are a Facilities Supervisor you can visualize all maintenance requests and assign a technician for each request,
            // also you can save and load all data of the program.
            //If you are a Church Leader you can ask one or many requests, and also you can record the request.
            //If you are Facilities technician you can visualize all technicians and cases assigned, also you can record maintenance services.
            //The first step you have to do is to enter one or many requests, the same church leader can enter one or many requests.
            //The second step is to assign a facilities technician to a request in the supervisor section, you can assign the technician to different requests.
            //The list request has two validation boxes, one for church leader and other for technician, the request only will be done if two boxes are checked,
            //if just one is checked, the supervisor has to clarify the reason.
            //The last step is the technician section, there you can visualize all technicians, and requests, also you can record them.


            Console.WriteLine("Welcome to the Church Maintenance Manangement System");
            Console.WriteLine();
            Console.WriteLine("1. Facilities Supervisor");
            Console.WriteLine("2. Church Leader");
            Console.WriteLine("3. Facilities Technician");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("Please select your charge: ");
            option = Console.ReadLine();

            if(option == "1" || option == "2" || option == "3")
            {

                if(option == "1")
                {
                    Console.Clear();

                    Console.WriteLine("Supervisor Menu: ");
                    Console.WriteLine();
                    Console.WriteLine("1. Assign maintenance service");
                    Console.WriteLine("2. Save Services");
                    Console.WriteLine("3. Load Services");
                    Console.WriteLine();
                    Console.WriteLine("Choose an option: ");
                    string optionSup = Console.ReadLine();

                    if(optionSup == "1" || optionSup == "2" || optionSup == "3")
                    {
                        if(optionSup == "1")
                        {
                            Console.Clear();
                            maintenanceManager.ShowServiceString();
                            maintenanceManager.AssignService();
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue.");
                            ConsoleKeyInfo key = Console.ReadKey();
                        }
                        else if(optionSup == "2")
                        {
                            maintenanceManager.SaveServices();
                        }
                        else
                        {
                            maintenanceManager.LoadServices();
                        }
                    }
                    else
                    {
                        maintenanceManager.ValidationMessage();
                    }
                } 
                else if(option == "2")
                {
                    Console.Clear();

                    Console.WriteLine("Church Leader Menu: ");
                    Console.WriteLine();
                    Console.WriteLine("1. Enter a request");
                    Console.WriteLine("2. Record a request");
                    Console.WriteLine();
                    Console.WriteLine("Choose an option: ");
                    string optionLead = Console.ReadLine();

                    if(optionLead == "1" || optionLead == "2")
                    {
                        if(optionLead == "1")
                        {
                            Console.Clear();

                            Console.WriteLine("Select your calling:");
                            Console.WriteLine();
                            Console.WriteLine("1. Temple President");
                            Console.WriteLine("2. Stake President");
                            Console.WriteLine();
                            Console.WriteLine("Enter your option");

                            string calling = Console.ReadLine();

                            if(calling == "1" || calling == "2")
                            {
                                Console.Clear();
                                maintenanceManager.AskService(calling);  
                            }
                            else
                            {
                                maintenanceManager.ValidationMessage();
                            }
                        }
                        else
                        {
                            
                            maintenanceManager.DisplayLeaderRequests();
                            maintenanceManager.RecordLeaderServices();
                            Console.WriteLine("Press enter to continue.");
                            ConsoleKeyInfo key = Console.ReadKey();
                        }
                    }
                    else
                    {
                        maintenanceManager.ValidationMessage();
                    } 
                } 
                else
                {
                    Console.Clear();

                    Console.WriteLine("Church Technician Menu: ");
                    Console.WriteLine();
                    Console.WriteLine("1. List technicians and requests");
                    Console.WriteLine("2. Record request");
                    Console.WriteLine();
                    Console.WriteLine("Choose an option: ");
                    string optionTech = Console.ReadLine();

                    if(optionTech == "1" || optionTech == "2")
                    {
                        if(optionTech == "1")
                        {
                            maintenanceManager.ListTechnicians();
                            Console.WriteLine("Press enter to continue.");
                            ConsoleKeyInfo key = Console.ReadKey();
                        }
                        else
                        {
                            maintenanceManager.DisplayTechnicianRequests();
                            maintenanceManager.RecordTechnicianServices();
                            Console.WriteLine("Press enter to continue.");
                            ConsoleKeyInfo key = Console.ReadKey();
                        }

                    }
                    else
                    {
                        maintenanceManager.ValidationMessage();
                    }

                }
            }
            else if(option == "4")
            {
                Console.Clear();
                Console.WriteLine("Good bye");
            }
            else
            {
                maintenanceManager.ValidationMessage();
            }

        } while (option != "4");



    }
}