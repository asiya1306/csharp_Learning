using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream fs = new FileStream(@"G:\Learning\cslearning\FileHandling\data.txt", FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(fs);
        int a = reader.ReadInt16();
        double b = reader.ReadDouble();
        string c = reader.ReadString();
        float d = reader.ReadSingle(); 
        

        Console.WriteLine("int: " + a);
        Console.WriteLine("double: " + b);
        Console.WriteLine("String: " + c);
        Console.WriteLine("Float: " + d);

        reader.Close();
        fs.Close();
    }
}
