using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class Addition
    {
        double a, b, result;
        public void getNum(double x, double y)
        {
            this.a= x; 
            this.b = y;
        }
        public void calAddition()
        {
            result = this.a+this.b;
        }
        public void displayAdd()
        {
            Console.WriteLine("Addition: " + result);
        }
    }

}
