public abstract class Shape
{
    protected string color;
    protected Boolean filled = true;    
    public Shape()
    {

    }
    public Shape(string color, Boolean filled)
    {
        this.color = color;
        this.filled = filled;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimetr();
    public virtual string ToString()
    {
        return $"{color} {filled}";
    }
}