﻿class MyBaseClass
{
    public static string CompanyName = "Microsoft";
    public int age;
    public string name;
}

class MyDerivedClass : MyBaseClass
{
    static void Main()
    {
        MyDerivedClass original = new MyDerivedClass();
        original.age = 42;
        original.name = "Alex";

        Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);

        // Klonlama.
        MyDerivedClass clone = original.MemberwiseClone() as MyDerivedClass;
        Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName + "\n");

        // Yoxlanış. 
        clone.age = 23;
        clone.name = "Konstantin";
        MyBaseClass.CompanyName = "TechEvo";

        Console.WriteLine(original.age + " " + original.name + " " + MyDerivedClass.CompanyName);
        Console.WriteLine(clone.age + " " + clone.name + " " + MyDerivedClass.CompanyName);

        // Delay.
        Console.ReadKey();
    }
}