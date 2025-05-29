using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction two = new Fraction(6);
        Fraction three = new Fraction(6, 7);
        Fraction four = new Fraction(2, 4);
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetNumerator());
        Console.WriteLine();
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDenominator());
        Console.WriteLine((double)three.GetNumerator() / (double)three.GetDenominator());
        Console.WriteLine(four.GetDecimalValue());
    }

}