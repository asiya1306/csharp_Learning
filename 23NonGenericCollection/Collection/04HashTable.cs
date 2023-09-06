using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class _04HashTable
    {
        public _04HashTable()
        {
            Console.WriteLine("Hash table\n");
            Hashtable table = new Hashtable();
            table.Add('c', 30);
            table.Add('a', 10);
            table.Add('d', 40);
            table.Add('b', 20);
            table.Add('e', 50);


            foreach (object obj in table.Keys)
            {
                Console.WriteLine("Hash items: " + table[obj]);
            }
            Console.WriteLine("Count:" + table.Count);
            table.Remove('d');
            Console.WriteLine("Count:" + table.Count);
        }
    }
}
