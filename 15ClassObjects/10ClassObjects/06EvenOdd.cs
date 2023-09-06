using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class EvenOdd
    {
        int num;
        public void getNum(int n)
        {
            this.num = n;
        }
        public void checkNum()
        {
            if (this.num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
