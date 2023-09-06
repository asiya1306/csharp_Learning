// See https://aka.ms/new-console-template for more information

internal class Circle
{
    private static void Main(string[] args)
    {
        //area of circle
        double area, r;
        const double pi = 3.14;
        Console.WriteLine("Enter Radius: ");
        r = int.Parse(Console.ReadLine());
        area = pi * r * r;
        Console.WriteLine("Area: " + area);
        Console.ReadKey();
    }
}
