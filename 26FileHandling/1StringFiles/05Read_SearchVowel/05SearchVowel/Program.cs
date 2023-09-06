using System.IO;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        FileStream fs = new FileStream(@"G:\Learning\cslearning\FileHandling\details.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string line = sr.ReadLine();

        int vowel_a = 0;
        int vowel_e = 0;
        int vowel_i = 0;
        int vowel_o = 0;
        int vowel_u = 0;


        while (line != null)
        {
            foreach (char c in line)
            {
                if (c == 'a' || c == 'A')
                {
                    vowel_a++;
                }
                else if(c == 'e' || c == 'E')
                {
                    vowel_e++;
                }
                else if (c == 'i' || c == 'I')
                {
                    vowel_i++;
                }
                else if (c == 'o' || c == 'O')
                {
                    vowel_o++;
                }
                else if (c == 'u' || c == 'U')
                {
                    vowel_u++;
                }
            }
            line = sr.ReadLine();
        }
        Console.WriteLine("Count of a or A: " + vowel_a);
        Console.WriteLine("Count of e or E: " + vowel_e);
        Console.WriteLine("Count of i or I: " + vowel_i);
        Console.WriteLine("Count of o or O: " + vowel_o);
        Console.WriteLine("Count of u or U: " + vowel_u);

        sr.Close();
        fs.Close();
    }
}