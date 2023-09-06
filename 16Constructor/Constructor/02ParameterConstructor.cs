using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class ParameterConstructor
    {
        int b,h;
        double area;

        public ParameterConstructor(int b , int h)
        {
            Console.WriteLine("Parameterized Constructor");
            this.b = b;
            this.h = h;           
        }
        public void TriangleCal()
        {
            area = 0.5 * b * h;
        }
        public void TraingleDisplay()
        {
            Console.WriteLine("Base: {0} , Height: {1} and Area is {2}", b, h, area);     
        }
    }
}
