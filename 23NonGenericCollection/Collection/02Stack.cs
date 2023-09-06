using System.Collections;

namespace Collection
{
    internal class _02Stack
    {
        public _02Stack()
        {
            Console.WriteLine("Stack\n");
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(3);
            stack.Push("asiya");
            foreach(object obj in stack)
            {
                Console.WriteLine("Stack items: " + obj);
            }
            Console.WriteLine("count " + stack.Count);
            stack.Pop();
            Console.WriteLine("count " + stack.Count);
            Console.WriteLine("Contains: "+stack.Contains("asiya"));
            Console.WriteLine(stack.Peek());
        }
    }
}
