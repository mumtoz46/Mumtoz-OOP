using System.Text.RegularExpressions;
public class Circle
{
    public double radius;
    public double pi=3.14;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }
    public void GetArea()
    {
            System.Console.WriteLine(radius * radius * pi);
    }
    public double GetCircumference()
    {
        return 2 * pi * radius;
    }
    public string ToString()
    {
        return $"Circle[{radius}]";
    }
}