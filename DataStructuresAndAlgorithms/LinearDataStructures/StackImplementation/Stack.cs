namespace StackImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int DefaultSize = 4;
        private T[] arrayOfElements;

        public Stack()
            : this(DefaultSize)
        {
        }

        public Stack(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Size cannot be null!");
            }

            this.arrayOfElements = new T[size];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T value)
        {
            if (this.Count == this.arrayOfElements.Length)
            {
                this.Resize();
            }

            this.arrayOfElements[this.Count] = value;
            this.Count += 1;
        }

        public T Pop()
        {
            var element = this.arrayOfElements[this.Count - 1];

            this.arrayOfElements[this.Count - 1] = default(T);
            this.Count -= 1;

            return element;
        }

        public T Peek()
        {
            var element = this.arrayOfElements[this.Count - 1];

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.arrayOfElements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void Resize()
        {
            var newArray = new T[this.arrayOfElements.Length * 2];

            Array.Copy(this.arrayOfElements, newArray, this.arrayOfElements.Length);
            this.arrayOfElements = newArray;
        }
    }
}
