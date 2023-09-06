internal class Program
{
    const string name = "Asiya";
    public const int age = 21;

    //const int BOD;        //error(requires initial value)
    public const int age1 = age;
    private static void Main(string[] args)
    {
        //age = 23;             //error(reinitialization to constant)
        Console.WriteLine(name);
        Console.WriteLine(age1);
    }
}