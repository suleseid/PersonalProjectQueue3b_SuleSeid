using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProjectQueue3b_SuleSeid
{
    // Main program class
    public class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            QueueStacks<int> queue = new QueueStacks<int>();

            queue.Enqueue(11);
            queue.Enqueue(25);
            queue.Enqueue(27);
            queue.Enqueue(45);
            queue.Enqueue(55);
            queue.Enqueue(66);

            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 11
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 11
            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 25
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 25

            //queue.Enqueue(27);
            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 27
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 27
            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 45
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 45
            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 55
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 55
            Console.WriteLine("Peek element: " + queue.Peek()); // Output: Peek: 66
            Console.WriteLine("Dequeue element: " + queue.Dequeue()); // Output: Dequeue: 66

            // Throws exception because queue is empty
            Console.WriteLine("Peek element: " + queue.Peek());
            Console.WriteLine("Dequeue element: " + queue.Dequeue());

        }
    }
}
