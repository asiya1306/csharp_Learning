using System;

public delegate void CallbackFunction(string message);

public class Processor
{
    public void ProcessData(string data, CallbackFunction callback)
    {
        Console.WriteLine($"Processing data: {data}");

        // Invoke the callback function
        callback("Processing complete!");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Processor processor = new Processor();

        // Define a callback function as a lambda expression
        CallbackFunction callback = (result) =>
        {
            Console.WriteLine($"Callback: {result}");
        };

        // Pass the callback function to the ProcessData method
        processor.ProcessData("Sample data", callback);
    }
}
