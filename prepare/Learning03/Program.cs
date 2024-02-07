using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f0 = new Fractions();
        f0.GetFractionString();
        Console.WriteLine(f0.GetDecimalValue());

        Fractions f1 = new Fractions(5);
        f1.GetFractionString();
        Console.WriteLine(f1.GetDecimalValue());

        Fractions f2 = new Fractions(3,4);
        f2.GetFractionString();
        Console.WriteLine(f2.GetDecimalValue());

        Fractions f3 = new Fractions(1,3);
        f3.GetFractionString();
        Console.WriteLine(f3.GetDecimalValue());


    }
}