using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Fraction basicFrac = new Fraction();
        Console.WriteLine(basicFrac.GetFractionString());
        Console.WriteLine(basicFrac.GetDecimalValue());

        Fraction wholeFrac = new Fraction(5);
        Console.WriteLine(wholeFrac.GetFractionString());
        Console.WriteLine(wholeFrac.GetDecimalValue());

        Fraction bothFrac = new Fraction(3, 4);
        Console.WriteLine(bothFrac.GetNumerator());
        Console.WriteLine(bothFrac.GetDenominator());
        Console.WriteLine(bothFrac.GetFractionString());
        Console.WriteLine(bothFrac.GetDecimalValue());
        bothFrac.SetNumerator(1);
        bothFrac.SetDenominator(2);
        Console.WriteLine(bothFrac.GetFractionString());
    }
}