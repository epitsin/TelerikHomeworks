namespace PriorityQueueWithBinaryHeap
{
    using System;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly BinaryHeap<T> heap;

        public int Count
        {
            get { return this.heap.Count; }
        }

        public PriorityQueue()
        {
            this.heap = new BinaryHeap<T>();
        }

        public void Enqueue(T element)
        {
            this.heap.Insert(element);
        }

        public T Dequeue()
        {
            return this.heap.Remove();
        }
    }
}
