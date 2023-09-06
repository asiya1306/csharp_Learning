using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class SimpleInterest
    {
        float si;
        int p, roi, t;
        const int div = 100;
        public void getSIData(int p, int roi,int t)
        {
            this.p = p;
            this.roi = roi;
            this.t = t;
        }
        public void calculateSI()
        {
            si = this.p * this.roi * this.t / div;
        }
        public void displaySI()
        {
            Console.WriteLine("Simple Interest :" + si);
        }
    }
}
