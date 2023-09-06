using System;

// Sealed class definition
public sealed class SealedClass
{
    private string message;

    public SealedClass(string message)
    {
        this.message = message;
    }

    public void DisplayMessage()
    {
        Console.WriteLine(message);
    }
}

// This line will not compile because you cannot inherit from a sealed class
// public class DerivedClass : SealedClass { }

public class Program
{
    static void Main(string[] args)
    {
        SealedClass sealedInstance = new SealedClass("This is a sealed class.");
        sealedInstance.DisplayMessage();
    }
}
