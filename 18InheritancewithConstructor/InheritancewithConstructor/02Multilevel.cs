using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancewithConstructor
{
    internal class _02Person
    {
        int Age = 22;
        string Name = "Fiza";

        public _02Person()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class _02Student : _02Person
    {
        int marks = 70;
        public _02Student() : base()
        {
            Console.WriteLine("Marks " + marks);
        }
    }
    class _02Employee : _02Student
    {
        int salary = 60000;
        public _02Employee() : base()
        {
            Console.WriteLine("Salary " + salary);
        }
    }
}
