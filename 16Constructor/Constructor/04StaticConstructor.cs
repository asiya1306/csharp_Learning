using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class StaticConstructor
    {
        int r;
        double area;
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor invoked");
        }
        public StaticConstructor()
        {
            r = 5;
        }
        public void CircleCal()
        {
            area = 3.14 * r * r;
        }
        public void CircleDisplay()
        {
            Console.WriteLine("Area of Circle: "+area);
        }
    }
}
