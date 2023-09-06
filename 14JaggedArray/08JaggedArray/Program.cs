using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //1.Jagged Array
        /*
        int[][] arr = new int[3][];
        arr[0] = new int[5];
        arr[1] = new int[3];
        arr[2] = new int[6];

        Console.WriteLine("enter 5 elements");
        for (int i = 0; i < 5; i++)
        {
            arr[0][i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter 3 elements");
        for (int i = 0; i < 3; i++)
        {
            arr[1][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter 6 elements");
        for (int i = 0; i < 6; i++)
        {
            arr[2][i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Write(arr[0][i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write(arr[1][i] + " ");
        }
        Console.WriteLine(); 
        
        for (int i = 0; i < 6; i++)
        {
            Console.Write(arr[2][i] + " ");
        }
        Console.WriteLine();
        */


        //2. Search element in jagged array
        /*
        int[][] arr1 = new int[3][];
        arr1[0] = new int[5];
        arr1[1] = new int[3];
        arr1[2] = new int[6];
        int targetElement;
        bool found = false;

        Console.WriteLine("enter 5 elements");
        for (int i = 0; i < 5; i++)
        {
            arr1[0][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter 3 elements");
        for (int i = 0; i < 3; i++)
        {
            arr1[1][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter 6 elements");
        for (int i = 0; i < 6; i++)
        {
            arr1[2][i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("enter element to be searches");
        targetElement = int.Parse(Console.ReadLine());
        for (int i= 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                if (arr1[i][j] == targetElement)
                {
                    found = true;
                    Console.WriteLine($"Element {targetElement} found at index [{i}][{j}].");
                    break;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine($"Element {targetElement} not found in the jagged array.");
        }
        */


        //3. Find min and max
        int[][] arr2 = new int[3][];
        int[] lengths = { 5, 3, 6 };
        Console.WriteLine("Enter elements for the jagged array:");
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = new int[lengths[i]];
            Console.WriteLine($"Enter {lengths[i]} elements for the array {i + 1}:");
            for (int j = 0; j < arr2[i].Length; j++)
            {
                arr2[i][j] = int.Parse(Console.ReadLine());
            }
        }

        int max = arr2[0][0];
        int min = arr2[0][0];

        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr2[i].Length; j++)
            {
                if (max < arr2[i][j])
                {
                    max = arr2[i][j];
                }
                if (min > arr2[i][j])
                {
                    min = arr2[i][j];
                }
            }
        }
        Console.WriteLine("Max number: " + max);
        Console.WriteLine("Min number: " + min);
    }
}