using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphism
{
    internal class Person
    {
        protected string name;
        protected int age, salary;

        public void GetData(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("Base Class");
            Console.WriteLine("name is: " + name);
            Console.WriteLine("age is: " + age);
            Console.WriteLine("salary is: " + salary);
        }
    }

    class Student : Person
    {
        new public void GetData(string name, int age, int salary)
        {
            base.GetData(name, age, salary);
        }

        new public void Display()
        {
            base.Display();
            Console.WriteLine("Derived Class method overridden");
        }
    }
}
