namespace Interface
{
    interface ICircle
    {
        void getData(int r);
        void cal();
        void display();
    }
    class Circle : ICircle
    {
        public int r;
        public const float pi = 3.14f;
        double area;
        public void getData(int r)
        {
            this.r = r;
        }
        public void cal()
        {
            area = pi * r * r;
        }
        public void display()
        {
            Console.WriteLine("Area of Circle: " + area);
        }
    }
}
