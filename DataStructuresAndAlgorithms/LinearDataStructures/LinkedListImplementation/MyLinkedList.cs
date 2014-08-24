namespace LinkedListImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyLinkedList<T> : IEnumerable<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public ListItem<T> LastElement { get; set; }

        public void AddFirst(T value)
        {
            var item = new ListItem<T>(value);

            if (this.FirstElement == null)
            {
                this.FirstElement = item;
                this.LastElement = item;
            }
            else
            {
                item.Next = this.FirstElement;
                this.FirstElement.Previous = item;
                this.FirstElement = item;
            }
        }

        public void AddLast(T value)
        {
            var item = new ListItem<T>(value);

            if (this.LastElement == null)
            {
                this.FirstElement = item;
                this.LastElement = item;
            }
            else
            {
                item.Previous = this.LastElement;
                this.LastElement.Next = item;
                this.LastElement = item;
            }
        }

        public void RemoveFirst()
        {
            var elementToBeRemoved = this.FirstElement;

            this.FirstElement = elementToBeRemoved.Next;
            this.FirstElement.Previous = null;
            elementToBeRemoved.Next = null;
        }

        public void RemoveLast()
        {
            var elementToBeRemoved = this.LastElement;

            this.LastElement = elementToBeRemoved.Previous;
            this.LastElement.Next = null;
            elementToBeRemoved.Previous = null;
        }

        public void Clear()
        {
            this.FirstElement = this.LastElement = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;
            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
