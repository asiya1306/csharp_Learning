using System;

namespace PartialClass
{
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }
}
