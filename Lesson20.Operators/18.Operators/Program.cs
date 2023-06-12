﻿Point a = new Point(1, 1);
Point b = new Point(2, 2);

Console.WriteLine("Point.Add(a, b) = {0}", Point.Add(a, b));

Console.WriteLine("Point.Subtract(a, b) = {0}", Point.Subtract(a, b));

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

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.x - p2.x, p1.y - p2.y);
    }

    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.x * p2.x, p1.y * p2.y);
    }

    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.x / p2.x, p1.y / p2.y);
    }

    // Metodlar.
    public override string ToString()
    {
        return string.Format("[{0}, {1}]", this.x, this.y);
    }

    // Operator + Add().
    public static Point Add(Point p1, Point p2)
    {
        return p1 + p2;
    }

    // Operator - Subtract().
    public static Point Subtract(Point p1, Point p2)
    {
        return p1 - p2;
    }
}