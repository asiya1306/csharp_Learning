using PartialClass;
using System;
public class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(2002, 6, 13)
        };

        person.DisplayFullName();
        Console.WriteLine($"Age: {person.CalculateAge()}");
    }
}
