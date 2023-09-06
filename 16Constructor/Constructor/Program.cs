using Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
       
        //Default constructor
        DefaultConstructor defaultConstructor = new DefaultConstructor();
        defaultConstructor.RectCal();
        defaultConstructor.RectDisplay();
        Console.WriteLine("--------------------------------------");

        //Parameterized Constructor
        ParameterConstructor Triangle1 = new ParameterConstructor(21, 19);
        ParameterConstructor Triangle2 = new ParameterConstructor(10, 14);

        Triangle1.TriangleCal();
        Triangle1.TraingleDisplay();
        Triangle2.TriangleCal();
        Triangle2.TraingleDisplay();
        Console.WriteLine("--------------------------------------");

        // Static Constructor
        StaticConstructor staticConstructor1 = new StaticConstructor();
        staticConstructor1.CircleCal();
        staticConstructor1.CircleDisplay();
        Console.WriteLine("--------------------------------------");


        //Copy Constructor
        CopyConstructor cp1 = new CopyConstructor(12000, 8, 7);
        cp1.SiCal();
        cp1.SiDisplay();
        CopyConstructor cp2 = new CopyConstructor(cp1);
        cp1.SiCal();
        cp1.SiDisplay();
        Console.WriteLine("--------------------------------------");


        //Constructor Overloading
        //ConstructorOverloading constructorOverloading = new ConstructorOverloading();
        //ConstructorOverloading constructorOverloading1 = new ConstructorOverloading(12, 34);
        //ConstructorOverloading constructorOverloading2 = new ConstructorOverloading(12, 34, 5);
    }
}