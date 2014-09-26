namespace PriorityQueueWithBinaryHeap
{
    using System;
    using System.Collections.Generic;

    public class BinaryHeap<T> where T : IComparable<T>
    {
        private readonly IList<T> heapArray;

        private int currentSize;

        public BinaryHeap()
        {
            this.currentSize = 0;
            this.heapArray = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.currentSize;
            }
        }

        public void CascadeDown(int index)
        {
            int largerChild;
            var top = this.heapArray[index];
            while (index < this.currentSize / 2)
            {
                int leftChild = (2 * index) + 1;
                int rightChild = leftChild + 1;
                if (rightChild < this.currentSize && this.heapArray[leftChild].CompareTo(this.heapArray[rightChild]) < 0)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                if (top.CompareTo(this.heapArray[largerChild]) >= 0)
                {
                    break;
                }

                this.heapArray[index] = this.heapArray[largerChild];
                index = largerChild;
            }

            this.heapArray[index] = top;
        }

        public void CascadeUp(int index)
        {
            int parent = (index - 1) / 2;
            var bottom = this.heapArray[index];
            while (index > 0 && this.heapArray[parent].CompareTo(bottom) < 0)
            {
                this.heapArray[index] = this.heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }

            this.heapArray[index] = bottom;
        }

        public bool Insert(T value)
        {
            this.heapArray.Add(value);
            this.CascadeUp(this.currentSize++);

            return true;
        }
        public T Remove()
        {
            var root = this.heapArray[0];
            this.heapArray[0] = this.heapArray[--this.currentSize];
            this.CascadeDown(0);
            return root;
        }
    }
}