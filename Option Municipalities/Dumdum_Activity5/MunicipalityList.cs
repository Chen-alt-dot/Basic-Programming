using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Activity5
{
    internal class MunicipalityList
    {
        // Private linked list to store municipalities
        private LinkedList<Municipality> list = new LinkedList<Municipality>();

        // Method to insert a municipality at the end of the list
        public void Insert(Municipality municipality)
        {
            list.AddLast(municipality); // Add at the end
        }

        // Method to remove a municipality by index
        public void Remove(int index)
        {
            // Check if index is within bounds
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Invalid index."); // Error message
                return; // Exit method
            }

            // Get the first node
            var current = list.First;

            // Traverse to the node at specified index
            for (int i = 0; i < index; i++)
            {
                current = current.Next; // Move to next node
            }

            // Remove the node at the specified position
            list.Remove(current);
            Console.WriteLine("Municipality removed successfully."); // Confirmation message
        }

        // Method to display all municipalities
        public void Display()
        {
            // Check if list is empty
            if (list.Count == 0)
            {
                Console.WriteLine("No municipalities to display."); // Message for empty list
                return;
            }

            int count = 0; // Counter for enumeration

            // Loop through each municipality in list
            foreach (var municipality in list)
            {
                Console.WriteLine($"--- Municipality {count + 1} ---"); // Display index
                municipality.DisplayMunicipality(); // Call polymorphic display method
                Console.WriteLine(); // Blank line for readability
                count++; // Increment counter
            }
        }
    }
}
