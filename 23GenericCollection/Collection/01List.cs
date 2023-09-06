using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class _01List
    {
        public _01List()
        {
            Console.WriteLine("ArrayList \n");
            List<int> list = new List<int>();
            list.Add(1);
            //list.Add("Asiya");          //Error
            list.Add(3);

            list.Insert(2, 416013);
            list.Insert(3, 6);

            foreach (object obj in list)
            {
                Console.WriteLine("Array items: " + obj);
            }
            Console.WriteLine("count " + list.Count);
            list.Remove(1);
            Console.WriteLine("count " + list.Count);
            Console.WriteLine("Contains " + list.Contains(6));
            Console.WriteLine(list.IndexOf(3));
        }
    }
}
