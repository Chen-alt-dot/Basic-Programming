using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Act9
{
    internal class Program
    {

        //Name: Christian Benedict P. Dumdum
        //Section: IT401A
        //REQUIREMENTS:
        //Implement the stack data structure and its basic operations in your code.
        //Initialize the stack as empty.
        //The coding structure must be in a procedural approach.
        //Data entry must be done via user input.
        //Apply exception handling.
        //Display appropriate output.
        static void Main(string[] args)
        {
            const int maxSize = 100; //Maximum Stack
            string[] stack = new string[maxSize]; //initialize the stack array
            int top = -1; //indicates that the "top" is the top element of the stack


            while (true) //loop
            {
                //Menu options for the user
                Console.WriteLine("Choose a Number:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");


                try
                {

                    //reading the user that input and parse it into integer
                    int choice = int.Parse(Console.ReadLine());

                    //using switch to handle the different choices of the user
                    switch (choice)
                    {

                        //Push Option
                        case 1:
                            if (top >= maxSize - 1)
                            {
                                Console.WriteLine(); // Space
                                //Check stack if it is over extend to its mximum number
                                Console.WriteLine("Stack is Already at Limit. Cannot push.");
                                Console.WriteLine(); // Space
                            }
                            else
                            {
                                Console.WriteLine(); // Space
                                //increment the stack 
                                Console.Write("Enter item to push: ");
                                string item = Console.ReadLine();
                                top++;
                                stack[top] = item;
                                Console.WriteLine($"'{item}' pushed onto the stack.");
                                Console.WriteLine(); // Space
                            }
                            break;

                        //Pop Option
                        case 2:

                            if (top < 0)
                            {
                                Console.WriteLine(); // Space
                                //Check if the stack is empty or not
                                Console.WriteLine("Stack is empty. Cannot pop.");
                            }
                            else
                            {
                                Console.WriteLine(); // Space
                                //retrieve the top item and decrement top
                                string poppedItem = stack[top];
                                top--;
                                Console.WriteLine($"'{poppedItem}' popped from the stack.");
                                Console.WriteLine(); // Space
                            }
                            break;
    
                        //Peek Option
                        case 3:
                            if (top < 0)
                            {
                                Console.WriteLine(); // Space
                                //When stack is empty 
                                Console.WriteLine("Error: Stack is empty. Nothing to peek.");
                                Console.WriteLine(); // Space
                            }
                            else
                            {
                                Console.WriteLine(); // Space
                                //Showing the top item without deleting the stack
                                Console.WriteLine($"Top of the stack: '{stack[top]}'");
                                Console.WriteLine(); // Space
                            }
                            break;

                        //Display Option
                        case 4:
                            if (top < 0)
                            {
                                Console.WriteLine(); // Space
                                //When Stack is empty. Nothing to Display
                                Console.WriteLine("Stack is empty.");
                                Console.WriteLine(); // Space
                            }
                            else
                            {
                                Console.WriteLine(); // Space
                                //Displaying the Stack
                                Console.WriteLine("Stack contents:");
                                for (int i = top; i >= 0; i--)
                                {
                                    Console.WriteLine(stack[i]);
                                }
                                Console.WriteLine(); // Space
                            }
                            break;

                        //Exit Option
                        case 5:
                            Console.WriteLine(); // Space
                            //Exit
                            Console.WriteLine("Exiting the program.");
                            return;


                        //Choosing only 1 - 5 if not the program will loop until you input the correct number
                        default:
                            Console.WriteLine(); // Space
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            Console.WriteLine(); // Space
                            break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine(); // Space
                    //Handle the input that cannot be parsed into integer
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine(); // Space
                }
            }
        }
    }
}
