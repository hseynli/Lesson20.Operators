MyClass instance = new MyClass();

Console.WriteLine(instance.GetHashCode());

// Delay.
Console.ReadKey();


class MyClass
{
    public override int GetHashCode()
    {
        return 1234567890;
    }
}