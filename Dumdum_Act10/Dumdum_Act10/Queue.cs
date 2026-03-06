using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumdum_Act10
{
    internal class Queue
    {
        private string[] items; // Array to store queue elements
        private int front;      // Index of the front element
        private int rear;       // Index of the rear element
        private int maxSize;    // Maximum size of the queue

        // Constructor to initialize the queue with a given size
        public Queue(int size)
        {
            maxSize = size;
            items = new string[maxSize];
            front = -1; // Indicates queue is initially empty
            rear = -1;
        }

        // Method to add an item to the queue
        public void Enqueue(string item)
        {
            if (rear == maxSize - 1)
            {
                // Queue is full
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return;
            }
            if (front == -1)
                front = 0; // Set front to 0 when first element is added
            rear++;
            items[rear] = item; // Add item at the rear
            Console.WriteLine($"'{item}' added to the queue.");
        }

        // Method to remove an item from the queue
        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                // Queue is empty
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return;
            }
            Console.WriteLine($"'{items[front]}' removed from the queue.");
            front++; // Move front to next element
            if (front > rear)
            {
                // Reset queue when all elements are dequeued
                front = -1;
                rear = -1;
            }
        }

        // Method to peek at the front item without removing
        public void Peek()
        {
            if (front == -1)
            {
                // Queue is empty
                Console.WriteLine("Queue is empty. Nothing to peek.");
            }
            else
            {
                Console.WriteLine($"Front of the queue: '{items[front]}'");
            }
        }

        // Method to display all items in the queue
        public void Display()
        {
            if (front == -1)
            {
                // Queue is empty
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Queue contents:");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }
    }
}
