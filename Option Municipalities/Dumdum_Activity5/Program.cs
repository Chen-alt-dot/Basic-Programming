using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Activity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the municipality list
            MunicipalityList municipalityList = new MunicipalityList();

            bool exit = false; // Loop control variable

            // Main loop for menu
            while (!exit)
            {

                // Display menu options
                Console.WriteLine("=== Municipality Management Menu ===");
                Console.WriteLine("1. Add Municipality");
                Console.WriteLine("2. Remove Municipality");
                Console.WriteLine("3. Display All Municipalities");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");


                string choice = Console.ReadLine(); // Read user choice

                switch (choice)
                {
                    case "1":
                        // Clear the console to provide a clean interface for adding a municipality
                        Console.Clear();
                        // Call method to add a new municipality
                        AddMunicipality(municipalityList);
                        // Prompt user to press any key before returning to the menu
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break; // Exit this case

                    case "2":
                        // Clear the console for clarity before removing a municipality
                        Console.Clear();
                        // Call method to remove a municipality by index
                        RemoveMunicipality(municipalityList);
                        // Wait for user input before returning to menu
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break; // Exit this case

                    case "3":
                        // Clear screen before displaying all municipalities
                        Console.Clear();
                        // Call method to display all municipalities
                        municipalityList.Display();
                        // Pause so user can see the output
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break; // Exit this case

                    case "4":
                        // Clear the console before exiting
                        Console.Clear();
                        // Set exit flag to true to end the main loop
                        exit = true;
                        break; // Exit this case

                    default:
                        // Clear the console for invalid input
                        Console.Clear();
                        // Inform user of invalid choice
                        Console.WriteLine("Invalid choice. Please select again.");
                        // Wait for user input before showing menu again
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break; // Exit this case
                }
            }
        }

        // Method to add a municipality
        static void AddMunicipality(MunicipalityList list)
        {
            // Ask user for the type of municipality
            Console.WriteLine("Select Municipality Type:");
            Console.WriteLine("1. NorthCebu");
            Console.WriteLine("2. CentralCebu");
            Console.Write("Enter choice (1 or 2): ");
            string typeChoice = Console.ReadLine();

            if (typeChoice == "1")
            {
                // Gather input for NorthCebu
                string barangay = UserInput.GetString("Enter Barangay: "); // Get Barangay
                string provinceName = UserInput.GetString("Enter Province Name: "); // Get Province Name
                double population = UserInput.GetDouble("Enter Population: "); // Get Population
                // Create new NorthCebu object
                NorthCebu nc = new NorthCebu(barangay, provinceName, population);
                list.Insert(nc); // Insert into list

                
            }
            else if (typeChoice == "2")
            {
                // Gather input for CentralCebu
                double postalCode = UserInput.GetDouble("Enter Postal Code: "); // Get PostalCode
                string provinceName = UserInput.GetString("Enter Province Name: "); // Get Province Name
                double population = UserInput.GetDouble("Enter Population: "); // Get Population
                // Create new CentralCebu object
                CentralCebu cc = new CentralCebu(postalCode, provinceName, population);
                list.Insert(cc); // Insert into list
            }
            else
            {
                Console.WriteLine("Invalid selection."); // Error message
            }
        }

        // Method to remove a municipality
        static void RemoveMunicipality(MunicipalityList list)
        {
            // Ask user for index to remove
            int index = (int)UserInput.GetDouble("Enter the index of municipality to remove (starting from 1): ") - 1;
            // Call remove method
            list.Remove(index);
        }
    }
}
        

    

   

