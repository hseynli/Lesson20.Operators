Point original = new Point(100, 100);
Point clone = original.Clone() as Point;

Console.WriteLine(original);
Console.WriteLine(clone);

clone.x = 0;

Console.WriteLine(original);
Console.WriteLine(clone);

// Delay.
Console.ReadKey();


public class Point : ICloneable
{
    public int x, y;

    public Point()
    {
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // ICloneable.
    public object Clone()
    {
        return new Point(this.x, this.y) as object;
    }

    public override string ToString()
    {
        return "X: " + x + " Y: " + y;
    }
}