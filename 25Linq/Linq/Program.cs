using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC Tutorials",
            "Java"
        };

        var result = from s in stringList
                     where s.Contains("Tutorials")
                     select s;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
