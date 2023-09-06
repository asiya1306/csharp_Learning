using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"G:\details.txt",FileMode.Create,FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Name : Asiya");
        sw.WriteLine("Age : 21");
        sw.WriteLine("Passout : 2023");
        sw.Close();
        fs.Close();
    }
}