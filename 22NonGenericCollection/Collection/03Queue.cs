using System.Collections;

namespace Collection
{
    internal class _03Queue
    {
        public _03Queue() {
            Console.WriteLine("Queue\n");
            Queue qu = new Queue();
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue("asiya");
            foreach (object obj in qu)
            {
                Console.WriteLine("Stack items: " + obj);
            }
            Console.WriteLine("count " + qu.Count);
            qu.Dequeue();
            Console.WriteLine("count " + qu.Count);
            Console.WriteLine("Index: ");
            Console.WriteLine("Contains: " + qu.Contains(2));
            Console.WriteLine(qu.Peek());
        }
    }
}
