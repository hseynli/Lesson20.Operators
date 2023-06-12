Point a = new Point(0, 0);

Console.WriteLine("a   = {0}", a);
Console.WriteLine("a++ = {0}", a++);
Console.WriteLine("a   = {0}", a);

Console.WriteLine("a-- = {0}", a--);
Console.WriteLine("a   = {0}", a);

Console.WriteLine("++a = {0}", ++a);
Console.WriteLine("a   = {0}", a);

Console.WriteLine("--a = {0}", --a);
Console.WriteLine("a   = {0}", a);

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

    // ++ overloading.
    public static Point operator ++(Point p1)
    {
        return new Point(p1.x + 1, p1.y + 1);
    }

    // -- overloading.
    public static Point operator --(Point p1)
    {
        return new Point(p1.x - 1, p1.y - 1);
    }

    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.x, this.y);
    }
}