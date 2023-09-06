namespace Inheritance
{
    internal class _02Person
    {
        int Age = 22;
        string Name = "Fiza";

        public void DisplayPerson()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class _02Student : _02Person
    {
        int marks = 70;
        public void DisplayStud()
        {
            base.DisplayPerson();
            Console.WriteLine("Marks " + marks);
        }
    }
    class _02Employee : _02Student
    {
        int salary = 60000;
        public void DisplayEmp()
        {
            base.DisplayStud();
            Console.WriteLine("Salary " + salary);
        }
    }
}
