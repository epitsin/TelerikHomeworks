// Implement the ADT stack as auto-resizable array. Resize the capacity on demand 
// (when no space is available to add / insert a new element).

namespace StackImplementation
{
    using System;

    public class StackImplementation
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("The numbers in the stack are: ");
            foreach (var number in stack)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The stack's count is: " + stack.Count);

            int popped = stack.Pop();

            Console.WriteLine("Pop the last element: " + popped);
            Console.WriteLine("Now the stack's count is: " + stack.Count);
            
            int peeked = stack.Peek();

            Console.WriteLine("Peek the last element: " + peeked);
            Console.WriteLine("The stack's count is still: " + stack.Count);
        }
    }
}
