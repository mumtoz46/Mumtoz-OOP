using System;
public class Square : Rectangle
{
    protected double side = 1.0;
    public Square()
    {

    }
    public Square (double side)
    {
        this.side = side;
    }
    public Square(double side, string color, bool filled)
    {
        this.side = side;
        this.color = color;
        this.filled = filled;
    }
    public double GetSide()
    {
        return side;
    }
    public void SetSide(double side)
    {
        this.side = side;
    }
    public void SetWidth(double side)
    {
        this.width = side;
    }
    public void SetLength(double side)
    {
        this.length = side;
    }
    public override string ToString()
    {
        return $"Square: [Rectangle [Shape [{color} {filled}] {width} {length}]]";
    }



}