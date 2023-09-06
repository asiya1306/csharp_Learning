using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //1. Multi-Dimensional Array
        /*
        int[,] arr1 = new int[3, 2];
        int i, j;
        Console.WriteLine("Enter 6 elemets");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                arr1[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine();
        }
        */


        //2.Addition of Two dimension arrays
        /*
        int[,] a = new int[3, 2];
        int[,] b = new int[3, 2];
        int[,] c = new int[3, 2];

        int i, j;
        //first array
        Console.WriteLine("enter 6 numbers:");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //second array
        Console.WriteLine("enter 6 numbers:");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }
        //calculating addition of array a and b
        for(i = 0; i < 3 ; i++)
        {
            for(j = 0; j < 2; j++)
            {
                c[i,j] = a[i, j] + b[i,j];
            }
        }
        //printing addition
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(c[i, j]+" ");
            }
            Console.WriteLine();
        }
        */


        //3.Transpose of Matrix
        int[,] arr2 = new int[3, 2];
        int i, j;
        Console.WriteLine("Enter 6 elemets");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                arr2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();
        }
        //transpose matrix
        Console.WriteLine("Transpose Matrix");
         for (j = 0; j < 2; j++)
         {
             for (i = 0; i < 3; i++)
             {
             Console.Write(arr2[i, j] + " ");
             }
            Console.WriteLine();
          }
    }
}