// Implement the ADT queue as dynamic linked list. 
// Use generics (LinkedQueue<T>) to allow storing different data types in the queue.

namespace LinkedQueueImplementation
{
    using System;

    public class LinkedQueueImplementation
    {
        public static void Main()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine("The numbers in the queue are: ");
            foreach (var number in queue)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The queue's count is: " + queue.Count);

            int dequeued = queue.Dequeue();

            Console.WriteLine("Dequeue the last element: " + dequeued);
            Console.WriteLine("Now the queue's count is: " + queue.Count);

            int peeked = queue.Peek();

            Console.WriteLine("Peek the last element: " + peeked);
            Console.WriteLine("The queue's count is still: " + queue.Count);
        }
    }
}
