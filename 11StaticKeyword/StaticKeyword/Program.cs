using StaticKeyword;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Static Variable");
        //_01StaticVariable staticVariable = new _01StaticVariable();
        //staticVariable.show();
        //_01StaticVariable staticVariable2 = new _01StaticVariable();
        //staticVariable2.show();
        //Console.WriteLine("----------------------------");

        Console.WriteLine("Static Method");
        _02StaticMethod instance1 = new _02StaticMethod();
        _02StaticMethod.show();
        instance1.display();

        _02StaticMethod instance2 = new _02StaticMethod();
        _02StaticMethod.show();
        instance2.display();

        //Console.WriteLine("----------------------------");
        //Console.WriteLine("Static Class");
        //_03StaticClass.sum(3, 4);
        //_03StaticClass.mul(8, 5);
    }
}