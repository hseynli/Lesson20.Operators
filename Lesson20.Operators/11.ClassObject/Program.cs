class A { public int a = 1; }
class B : A { public int b = 2; }
class C : B { public int c = 3; }
class X : C { }

class Program : X
{
    static void Main()
    {
        Program original = new Program();
        Console.WriteLine("Original : " + original.a + " " + original.b + " " + original.c);

        // Obyektin klonlaması. 
        Program clone = original.MemberwiseClone() as Program;
        Console.WriteLine("Klon : " + clone.a + " " + clone.b + " " + clone.c + "\n");

        // Dərin klonlamanı yoxlamaq
        clone.a = clone.b = clone.c = 7;

        Console.WriteLine("Original : " + original.a + " " + original.b + " " + original.c);
        Console.WriteLine("Klon : " + clone.a + " " + clone.b + " " + clone.c);

        // Delay.
        Console.ReadKey();
    }
}