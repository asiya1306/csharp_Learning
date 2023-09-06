namespace AbstractClass
{
    abstract class RectAbs
    {
        public abstract void getData(int l, int b);
        public abstract int cal();
        public void display(int a)
        {
            Console.WriteLine("area of rectangle: " + a);
        }
    }
    class Rectangle : RectAbs
    {
        int length, breadth;
        public override void getData(int l, int b)
        {
            this.length = l;
            this.breadth = b;
        }
        public override int cal()
        {
            return (length * breadth);
        }
    }
}
