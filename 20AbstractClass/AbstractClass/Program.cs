
using AbstractClass;

internal class Program
{
    private static void Main(string[] args)
    {
        _01Demo demo = new _01Demo();
        demo.show();
        demo.display();

        //Circle
        Circle circle = new Circle();
        circle.getData(6);
        float a = circle.cal();
        circle.display(a);

        //rectangle
        Rectangle  rectangle = new Rectangle();
        rectangle.getData(4, 5);
        int area = rectangle.cal();
        rectangle.display(area);
    }
}