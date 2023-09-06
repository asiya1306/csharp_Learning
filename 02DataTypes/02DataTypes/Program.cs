//Predefined Datatypes (built-in datatypes)
internal class Program
{
    private static void Main(string[] args)
    {
        //1. Value type
        byte myByte = 200;
        sbyte mySByte = -50;
        short myShort = -15000;
        ushort myUShort = 50000;
        int myInt = -2000000000;
        uint myUInt = 3000000000;
        long myLong = -9000000000000000000;
        ulong myULong = 18000000000000000000;
        float myFloat = 3.14f;
        double myDouble = 2.71828;
        decimal myDecimal = 12345.6789m;
        char myChar = 'A';
        bool myBool = true;

        Console.WriteLine("byte: " + myByte);
        Console.WriteLine("sbyte: " + mySByte);
        Console.WriteLine("short: " + myShort);
        Console.WriteLine("ushort: " + myUShort);
        Console.WriteLine("int: " + myInt);
        Console.WriteLine("uint: " + myUInt);
        Console.WriteLine("long: " + myLong);
        Console.WriteLine("ulong: " + myULong);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("decimal: " + myDecimal);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("bool: " + myBool);

        //2. Refernce type (String, array, object)

        string str = new string("Asiya");
        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("String: " + str);
        Console.WriteLine("Array: " + arr[0]);
    }
}