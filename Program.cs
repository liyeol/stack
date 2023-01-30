using System;
using System.Collections.Generic;

namespace StackClass
{
    class Stack<T>
    {
        private List<T> stack = new List<T>();

        public int Count
        {
            get { return stack.Count; }
        }

        public void Push(T obj)
        {
            stack.Add(obj);
        }

        public T Pop()
        {
            T obj = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return obj;
        }

        public T Peek()
        {
            return stack[stack.Count - 1];
        }

        public void Clear()
        {
            stack.Clear();
        }

        public void CopyTo(T[] arr)
        {
            stack.CopyTo(arr);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Count: " + stack.Count);
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Count: " + stack.Count);

            int[] arr = new int[stack.Count];
            stack.CopyTo(arr);
            Console.WriteLine("Array: " + string.Join(", ", arr));

            stack.Clear();
            Console.WriteLine("Count: " + stack.Count);
        }
    }
}