using System.Collections;

namespace Collection
{
    internal class _05SortedList
    {
        public _05SortedList()
        {
            Console.WriteLine("SortedList\n");
            SortedList list = new SortedList();
            list.Add(3, 30);
            list.Add(1, 10);
            list.Add(4, 40);
            list.Add(2, 20);
            list.Add(5, 50);


            foreach (object obj in list.Keys)
            {
                Console.WriteLine("Sorted List items: " + list[obj]);
            }
            Console.WriteLine("Count:"+ list.Count);
            list.Remove(4);
            Console.WriteLine("Count:" + list.Count);

        }
    }
}
