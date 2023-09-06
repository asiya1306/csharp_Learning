using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    internal class _02StaticMethod
    {
        static int a;
        int b;

        public _02StaticMethod()
        {
            a++;
            b++;
        }
        public static void show()
        {
            Console.WriteLine("a is:" + a);
        }
        public void display()
        {
            Console.WriteLine("b is:" + b);
        }
    }
}
