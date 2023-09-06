using _01UserProfile;

internal class Program
{
    private static void Main(string[] args)
    {
        //read and write
        Username un = new Username();
        un.Message();
        Console.WriteLine("Enter Username");
        un.username = Console.ReadLine();
        Console.WriteLine("Your Name is: " + un.username);

        //read only
        RegisterDate reg = new RegisterDate();
        reg.Message();
        //reg.Registration = Console.ReadLine();                 // Attempt to write Registration Date (compile error)
        Console.WriteLine("Registration Time: " + reg.Registration);

        //write only
        Password pa = new Password();
        pa.Message();
        Console.WriteLine("Enter Password");
        pa.password = int.Parse(Console.ReadLine());
        //Console.WriteLine("Your password: " + pa.password);    // Attempt to read Password (compile error)

    }
}