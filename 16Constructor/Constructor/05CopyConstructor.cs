using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class CopyConstructor
    {
        int principal, roi, time;
        double si;
        public CopyConstructor(int principal,int roi,int time)
        {
            Console.WriteLine("Original Constructor");
            this.principal = principal;
            this.roi = roi;
            this.time = time;
        }
        public CopyConstructor(CopyConstructor cp2)
        {
            Console.WriteLine("Copied Constructor");
            principal = cp2.principal;
            roi = cp2.roi;
            time = cp2.time;
        }
        public void SiCal()
        {
            si = principal * roi * time / 100;
        }
        public void SiDisplay()
        {
            Console.WriteLine("Simple Interest: "+si);
        }
    }
}
