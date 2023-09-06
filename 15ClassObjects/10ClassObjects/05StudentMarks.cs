using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ClassObjects
{
    internal class StudentMarks
    {
        float m1, m2, m3, total, perccent;
        public void getMarks(float m1,float m2, float m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void calculateMarks()
        {
            total = this.m1 + this.m2 + this.m3;
            perccent = total / 3;
        }
        public void displayMarks()
        {
            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Percentatge: " + perccent);
        }
    }
}
