using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"G:\Learning\cslearning\FileHandling\marks.txt", FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        int m1, m2, m3, total, percent;
        Console.WriteLine("Enter marks of 3 subjects :");
        m1 = int.Parse(Console.ReadLine());
        m2 = int.Parse(Console.ReadLine());
        m3 = int.Parse(Console.ReadLine());

        total = m1 + m2 + m3;
        percent = total / 3;
        sw.WriteLine("Total: " + total);
        sw.WriteLine("Percentatge: " + percent);

        sw.Close();
        fs.Close();
    }
}