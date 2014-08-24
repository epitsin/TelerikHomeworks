// Implement the data structure linked list. Define a class ListItem<T> 
//    that has two fields: value (of type T) and NextItem (of type ListItem<T>). 
//    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).

namespace LinkedListImplementation
{
    using System;

    public class LinkedListImplementation
    {
        public static void Main()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(3);
            list.AddFirst(5);
            list.AddFirst(6);
            list.AddFirst(9);
            list.AddFirst(8);

            PrintResults(list);
        }

        private static void PrintResults(MyLinkedList<int> myList)
        {
            Console.WriteLine("The sequence of numbers is: ");
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The first element is: " + myList.FirstElement.Value);
            Console.WriteLine("The last element is: " + myList.LastElement.Value);

            myList.RemoveFirst();
            myList.RemoveLast();

            Console.WriteLine("After the first element is removed, the new first element is: " + myList.FirstElement.Value);
            Console.WriteLine("After the last element is removed, the new last element is: " + myList.LastElement.Value);
        }
    }
}
