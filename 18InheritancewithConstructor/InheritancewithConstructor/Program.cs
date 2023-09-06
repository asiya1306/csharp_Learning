using InheritancewithConstructor;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Single inheritance with constructor");
        Student stud = new Student();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Multilevel inheritance with constructor");
        _02Employee emp2 = new _02Employee();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Hierarchical inheritance with constructor");
        _03Student stud3 = new _03Student();
        _03Employee emp3 = new _03Employee();
        Console.WriteLine("-----------------------------");


    }
}