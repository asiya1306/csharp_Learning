namespace Inheritance
{
    internal class Person
    {
        int Age = 21;
        string Name = "Asiya";

        public void DisplayPerson()
        {
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Name " + Name);
        }
    }

    class Student : Person
    {
        int marks = 90;
        public void DisplayStud()
        {
            base.DisplayPerson();
            Console.WriteLine("Salary " + this.marks);
        }
    }
}
