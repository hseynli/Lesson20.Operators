Point a = new Point(1, 1);
Point b = new Point(2, 2);

Console.WriteLine("a == b = {0}", a == b);
Console.WriteLine("a != b = {0}", a != b);

Console.WriteLine(new string('-', 15));

Point c = new Point(1, 1);

Console.WriteLine("a == c = {0}", a == c);
Console.WriteLine("a != c = {0}", a != c);

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

    // == overloading.
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.Equals(p2);
    }

    // != overloading.
    public static bool operator !=(Point p1, Point p2)
    {
        return !p1.Equals(p2);
    }

    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.x, this.y);
    }

    public override bool Equals(object o)
    {
        if (o is Point)
        {
            if (((Point)o).x == this.x && ((Point)o).y == this.y)
                return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }
}