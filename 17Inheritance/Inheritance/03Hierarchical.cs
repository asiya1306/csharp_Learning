namespace Inheritance
{
    internal class _03Person
    {
        int Age = 23;
        string Name = "Yashashri";

        public void DisplayPerson()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class _03Student : _03Person
    {
        int marks = 85;
        public void DisplayStud()
        {
            base.DisplayPerson();
            Console.WriteLine("Marks " + marks);
        }
    }
    class _03Employee : _03Person
    {
        int salary = 50000;
        public void DisplayEmp()
        {
            base.DisplayPerson();
            Console.WriteLine("Salary " + salary);
        }
    }
}
