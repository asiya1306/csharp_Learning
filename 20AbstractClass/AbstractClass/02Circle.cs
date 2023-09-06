namespace AbstractClass
{
    abstract class _02Circle
    {
        public abstract void getData(int r);
        public abstract float cal();
        public void display(float a)
        {
            Console.WriteLine("area of circle: " + a);
        }
    }
    class Circle : _02Circle
    {
        int r;
        public override void getData(int r)
        {
            this.r = r;
        }
        public override float cal()
        {
            return (3.14f * r * r);
        }
    }
}
