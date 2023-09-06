
namespace AbstractClass
{
    abstract class Demo
    {
        public abstract void show();

        public void display()
        {
            Console.WriteLine("hello world");
        }
    }
     class _01Demo :  Demo
     {
        public override void show()
        {
            Console.WriteLine("Welcome");
        }
    }
}
