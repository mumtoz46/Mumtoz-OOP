public class Rectangle : Shape
{
    protected double width = 1.0;
    protected double length = 1.0;
    public Rectangle()
    {

    }
    public Rectangle (double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public Rectangle(double width, double length, string color, bool filled) : base (color, filled)
    {
        this.width = width;
        this.length = length;
    }
    public double GetWidth()
    {
        return width;
    }
    public void SetWidth(double width)
    {
        this.width = width;
    }
    public double GetLength()
    {
        return length;
    }
    public void SetLength(double length)
    {
        this.length = length;
    }
    public override double GetArea()
    {
        
         return width * length;
    }
    public override double GetPerimetr()
    {
        return 2 * (width+length);
    }
    public override string ToString()
    {
        return $"Rectangle:[Shape [{color} {filled}] {width} {length}]";
    }
}