using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Constructor
{
    internal class DefaultConstructor
    {
        int len, wid;
        double area;
        public DefaultConstructor()
        {
            Console.WriteLine("Default Constructor");
            len = 10;
            wid = 12;
        }
        public void RectCal()
        {
            area = len * wid;
        }
        public void RectDisplay()
        {
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
