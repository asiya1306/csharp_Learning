internal class Program
{
    private static void Main(string[] args)
    {
        //1.Single Dimentional Array
        /*
        int[] arr1 = new int[5];
        int i;
        Console.WriteLine("enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < 5; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        */


        //2. Addition of Array elements
        /*
        int[] arr2 = new int[5];
        int i,sum;
        sum = 0;
        Console.WriteLine("enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
            sum = sum + arr2[i];
        }
        Console.WriteLine("Sum of an array :"+ sum);
        */


        //3.Addition of Two arrays
        /*
        int[] a = new int[5];
        int[] b = new int[5];
        int[] c = new int[5];
        int i;

        Console.WriteLine("Enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        for(i=0;i< 5; i++)
        {
            c[i] = a[i] + b[i];
        }

        for (i = 0; i < 5; i++)
        {
            Console.Write(c[i] + " ");
        }
        */


        //4. Search element in array

        int[] arr3 = new int[5];
        int i, num;
        bool flag = false;
        Console.WriteLine("enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            arr3[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter number to be Searched");
        num = int.Parse(Console.ReadLine());
        for (i = 0; i < 5; i++)
        {
            if (arr3[i] == num)
            {
                Console.Write("Element Found at position " + i);
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            Console.WriteLine("Element Not found");
        }



        //5. Find Min and Max
        /*
        int[] arr4 = new int[5];
        int i, min, max;

        Console.WriteLine("enter 5 numbers");
        for (i = 0; i < 5; i++)
        {
            arr4[i] = int.Parse(Console.ReadLine());
        }

        max = arr4[0];
        min = arr4[0];

        for (i = 0; i < 5; i++)
        {
            if (max < arr4[i])
            {
                max = arr4[i];
            }
            if (min > arr4[i])
            {
                min = arr4[i];
            }
        }
            
        Console.WriteLine("max number: " + max);
        Console.WriteLine("min number: " + min);
        */
    }
}