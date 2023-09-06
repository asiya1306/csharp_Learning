using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class ConstructorOverloading
    {
        public ConstructorOverloading()
        {
            Console.WriteLine("Default Constructor");
        }
        public ConstructorOverloading(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public ConstructorOverloading(int a,int b,double c)
        {
            Console.WriteLine(a*b*c);
        }
    }
}
