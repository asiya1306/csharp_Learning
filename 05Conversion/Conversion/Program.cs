using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //1. implicit type conversion
        int a = 9;
        float b = a;     
        Console.WriteLine(b);       //9

        double dd = b;
        Console.WriteLine(dd);      //9

        char cc = 'a';
        int ii = cc;
        Console.WriteLine(cc);      // 'a'
        Console.WriteLine(ii);      //97

        int x = 70;
        Console.WriteLine(x.ToString());

        //2. explicit type conversion

        float c = 10.77f;
        //int d = c;          //eroor   
        Console.WriteLine(Convert.ToInt32(c));           //11

        int e = int.Parse("99");
        float f = float.Parse("88");
        Console.WriteLine(e);               //99
        Console.WriteLine(f);               //88

        double g = 5.9;
        float h = (float)g;
        Console.WriteLine(h);               //5.9
    }
}