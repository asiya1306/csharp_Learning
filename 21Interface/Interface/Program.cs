using Interface;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.Single
        Circle circle = new Circle();
        circle.getData(9);
        circle.cal();
        circle.display();
        Console.WriteLine("---------------------------------");
        //2.Multiple
        Person person = new Person();
        person.getStud("Asiya", 21, 78);
        person.displayStud();
        person.getFaculty("Prof.A.S.Hmbarde", 38, "IoT");
        person.displayFaculty();
        Console.WriteLine("---------------------------------");

        //Multilevel
        Person1 person1 = new Person1();
        person1.getGrand("Sikandar Shaikh", 78, "ITI");
        person1.displayGrand();
        person1.getParent("Farukh Shaikh", 50, "Civil Engineering");
        person1.displayParent();
        person1.getChild("Asiya Shaikh", 21, "Computer Engineering");
        person1.displayChild();
        Console.WriteLine("---------------------------------");

    }
}