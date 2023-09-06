using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancewithConstructor
{
    internal class _03Person
    {
        int Age = 23;
        string Name = "Yashashri";

        public _03Person()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class _03Student : _03Person
    {
        int marks = 85;
        public _03Student() : base()
        {
            Console.WriteLine("Marks " + marks);
        }
    }
    class _03Employee : _03Person
    {
        int salary = 50000;
        public _03Employee() : base()
        {
            Console.WriteLine("Salary " + salary);
        }
    }
}
