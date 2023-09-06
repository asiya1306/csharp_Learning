using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"G:\Learning\cslearning\FileHandling\marks.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string s = sr.ReadLine();

        while (s != null)
        {
            Console.WriteLine(s);
            s = sr.ReadLine();
        }
        sr.Close();
        fs.Close();
    }
}