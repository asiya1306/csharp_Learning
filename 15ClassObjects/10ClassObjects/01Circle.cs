using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class Circle
    {
        int r;
        double area;
        const double pi = 3.14;
        public void getData(int rad)
        {
            this.r = rad;
        }
        public void calculate()
        {
            area = pi * this.r * this.r;
        }
        public void getArea()
        {
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
