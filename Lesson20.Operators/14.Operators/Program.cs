Point a = new Point(1, 1);
Point b = new Point(2, 2);

Point c = a + b;

Console.WriteLine("c = {0}", c);

// Delay.
Console.ReadKey();

public struct Point
{
    private int x, y;

    public Point(int xPos, int yPos)
    {
        x = xPos;
        y = yPos;
    }

    // operator açar sözünü ancaq statik açar sözü ilə eyni zamanda istifadə etmək olar!
    // + operatorunun overloadı.
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.x, this.y);
    }
}