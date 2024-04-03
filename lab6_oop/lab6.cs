using System;

class Program
{
    static int ComputeIntegerPart(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        return numerator / denominator;
    }

    static void Main(string[] args)
    {
        int numerator = 17;
        int denominator = 5;

        int integerPart = ComputeIntegerPart(numerator, denominator);
        Console.WriteLine($"The integer part of {numerator}/{denominator} is: {integerPart}");
    }
}
