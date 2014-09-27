// 1.Implement a class PriorityQueue<T> based on the data structure "binary heap".

namespace PriorityQueueWithBinaryHeap
{
    using System;

    public class PriorityQueueEntryPoint
    {
        public static void Main()
        {
            var priorityQueueInts = new PriorityQueue<int>();

            priorityQueueInts.Enqueue(1);
            priorityQueueInts.Enqueue(10);
            priorityQueueInts.Enqueue(2);
            priorityQueueInts.Enqueue(1);
            priorityQueueInts.Enqueue(3);
            priorityQueueInts.Enqueue(13);
            priorityQueueInts.Enqueue(4);
            priorityQueueInts.Enqueue(5);

            while (priorityQueueInts.Count > 0)
            {
                Console.WriteLine(priorityQueueInts.Dequeue());
            }         
        }
    }
}
