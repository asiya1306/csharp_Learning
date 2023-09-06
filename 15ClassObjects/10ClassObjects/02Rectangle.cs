using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class Rectangle
    {
        int area,l,w;
        public void getData(int len, int wid)
        {
            this.l = len;
            this.w = wid;
        }
        public void calculate()
        {
            area = this.l * this.w;
        }
        public void display()
        {
            Console.WriteLine("area of rectangle :"+area);
        }
    }
}
