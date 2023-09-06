using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancewithConstructor
{
    internal class Person
    {
        int Age = 21;
        string Name = "Asiya";

        public Person()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class Student : Person
    {
        int marks = 90;
        public Student() : base()
        {    
            Console.WriteLine("Salary " + this.marks);
        }
    }
}
