using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class _01MethodOverloading
    {
        public void area(int radius)
        {
            Console.WriteLine("Area of Circle:" + 3.14 * radius * radius);
        }
        public void area(int height, int base1)
        {
            Console.WriteLine("Area of Triangle:" + 0.5 * height * base1);
        }
        public void area(float side)
        {
            Console.WriteLine("Area of Square:" + side * side);
        }
        public void area(float length,float breadth)
        {
            Console.WriteLine("Area of Rectangle:" + length * breadth);

        }


    }
}
