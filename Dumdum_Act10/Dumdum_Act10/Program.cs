using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Act10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxSize = 100; //Size of the queue or capacity
            Queue queue = new Queue(maxSize); //Array

            while (true)
            {
                // Display menu options to the user
                Console.WriteLine("");//Space
                Console.WriteLine("Choose Queue Options:");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                try
                {
                    // Read user choice
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            // Enqueue option
                            Console.WriteLine("");//Space
                            Console.Write("Enter item to enqueue: ");
                            string item = Console.ReadLine();
                            queue.Enqueue(item);
                            break;
                        case 2:
                            // Dequeue option
                            Console.WriteLine("");//Space
                            queue.Dequeue();
                            break;
                        case 3:
                            // Peek option
                            Console.WriteLine("");//Space
                            queue.Peek();
                            break;
                        case 4:
                            // Display option
                            Console.WriteLine("");//Space
                            queue.Display();
                            break;
                        case 5:
                            // Exit program
                            Console.WriteLine("");//Space
                            Console.WriteLine("Thankyou!!!");
                            return;
                        default:
                            // Invalid menu choice
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // Handle invalid input that isn't a number
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.ReadKey();
            }
        }
    }
    
}
    

