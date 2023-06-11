MyClass instance = new MyClass();

Console.WriteLine(instance.ToString());

// Delay.
Console.ReadKey();


class MyClass
{
    public override string ToString()
    {
        return "Hello world!";
    }
}