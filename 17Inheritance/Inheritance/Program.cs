using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Single inheritance");
        Student stud = new Student();
        stud.DisplayStud();
        Console.WriteLine("-----------------------------");


        Console.WriteLine("Multilevel inheritance");
        _02Employee emp = new _02Employee();
        emp.DisplayEmp();
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Hierarchical inheritance");
        _03Student stud1 = new _03Student();
        stud1.DisplayStud();
        Console.WriteLine("");
        _03Employee emp1 = new _03Employee();
        emp1.DisplayEmp();
    }
}