namespace LinkedQueueImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using LinkedListImplementation;

    public class Queue<T> : IEnumerable<T>
    {
        //I am using my own implementation of linked list.
        private readonly MyLinkedList<T> listOfElements;

        public Queue()
        {
            this.listOfElements = new MyLinkedList<T>();
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Enqueue(T value)
        {
            this.listOfElements.AddLast(value);
            this.Count += 1;
        }

        public T Dequeue()
        {
            if (this.listOfElements.FirstElement == null)
            {
                throw new ArgumentNullException("The queue is empty!");
            }

            var element = this.listOfElements.FirstElement;

            this.listOfElements.RemoveFirst();
            this.Count -= 1;

            return element.Value;
        }

        public T Peek()
        {
            if (this.listOfElements.FirstElement == null)
            {
                throw new ArgumentNullException("The queue is empty!");
            }

            var element = this.listOfElements.FirstElement;

            return element.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.listOfElements)
            {
                yield return element;
            }
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
