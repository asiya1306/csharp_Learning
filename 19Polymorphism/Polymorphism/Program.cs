using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        //method overloading
        _01MethodOverloading overloading = new _01MethodOverloading();
        overloading.area(7);
        overloading.area(3,8);
        overloading.area(2.5f,6.2f);
        overloading.area(9.2f);
        Console.WriteLine("------------------------------------");

        //method overriding
        Student stud = new Student();
        stud.GetData("Asiya", 22, 70000);
        stud.Display();

        Console.WriteLine("------------------------------------");

    }
}