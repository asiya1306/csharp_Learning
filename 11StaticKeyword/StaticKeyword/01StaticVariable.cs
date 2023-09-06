using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    internal class _01StaticVariable
    {
        static int a;
        int b;

        public _01StaticVariable()
        {
            a++;
            b++;
        }
        public void show()
        {
            Console.WriteLine("a is {0} and b is {1}",a,b);
        }
    }
}
