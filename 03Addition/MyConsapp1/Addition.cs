internal class Addition
{
    private static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Enter Two numbers");         //Writing to console
        a = int.Parse(Console.ReadLine());              //Reading from console
        b= int.Parse(Console.ReadLine());
        c = a + b;
        Console.WriteLine("Addition: "+ c);
        Console.ReadKey();                              //Hold Output or Console window
    }
}