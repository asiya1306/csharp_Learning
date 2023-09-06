using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream fs = new FileStream(@"G:\Learning\cslearning\FileHandling\data.txt", FileMode.OpenOrCreate, FileAccess.Write);
        BinaryWriter writer = new BinaryWriter(fs);
        {
            writer.Write(42);         // Write an integer
            writer.Write(3.14);       // Write a double
            writer.Write("Hello");    // Write a string
            writer.Write(9.348123456789012345f);    // Write a string
            writer.Close();
            fs.Close();
        }
    }
}
