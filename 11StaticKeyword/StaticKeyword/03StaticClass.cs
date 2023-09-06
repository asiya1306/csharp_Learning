using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    static class _03StaticClass
    {
        static _03StaticClass()
        {
            Console.WriteLine("Static constructor of Static class ");
        }
        public static void sum(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void mul(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
