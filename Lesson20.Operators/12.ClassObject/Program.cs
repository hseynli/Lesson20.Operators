﻿class A { public int a = 1; }
class B { public int b = 2; }
class C { public B B = new B(); }

class X
{
    public A A = new A();
    public C C = new C();
}

class Program : X
{
    static void Main()
    {
        Program original = new Program();
        Console.WriteLine("Original : " + original.A.a + " " + original.C.B.b);

        // Obyektin klonlaması
        Program clone = original.MemberwiseClone() as Program;
        Console.WriteLine("Klon : " + clone.A.a + " " + clone.C.B.b + "\n");

        // Dərin klonlamanı yoxlamaq
        clone.A.a = clone.C.B.b = 7;

        Console.WriteLine("Original : " + original.A.a + " " + original.C.B.b);
        Console.WriteLine("Klon : " + clone.A.a + " " + clone.C.B.b);

        // Delay.
        Console.ReadKey();
    }
}