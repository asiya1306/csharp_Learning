using System.Collections;

namespace Collection
{
    internal class _01ArrayList
    {
        public _01ArrayList()
        {
            Console.WriteLine("ArrayList \n");
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add("Asiya");
            a.Add("Kolhapur");

            a.Insert(2, 416013);
            a.Insert(3, "rk nagar");

            foreach (object obj in a)
            {
                Console.WriteLine("Array items: " + obj);
            }
            Console.WriteLine("count " + a.Count);
            a.Remove(1);
            Console.WriteLine("count " + a.Count);
            Console.WriteLine("Contains " + a.Contains("Kolhapur"));
            Console.WriteLine(a.IndexOf("Asiya"));
        }
    }
}
