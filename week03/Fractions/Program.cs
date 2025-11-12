using System;
using Fractions;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);


        Console.WriteLine($"Fraction 1: {fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        fraction3.SetTop(7);
        fraction3.SetBottom(8);
        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal value of Fraction 3: {fraction3.GetDecimalValue()}");

    }
}