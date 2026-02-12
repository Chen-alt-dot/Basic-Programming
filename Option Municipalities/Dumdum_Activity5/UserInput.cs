using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Activity5
{
    internal class UserInput // Static class for user input with exception handling
    {
        public static string GetString(string prompt) // Method to get string input from user
        {
            Console.Write(prompt); //Display
            return Console.ReadLine(); //Read User Input
        }

        // Method to get double input with exception handling
        public static double GetDouble(string prompt)
        {
            while (true) // Loop until valid input is received
            {
                try
                {
                    Console.Write(prompt); // Display prompt
                    string input = Console.ReadLine();  // Read input
                    return Convert.ToDouble(input); // Convert to double and return
                }
                catch (FormatException) // Catch invalid format exception
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); //Display if invalid input
                }
            }
        }
    }
}
