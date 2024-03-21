using System;


public static class RootOfNumber
{
    public static double SquareRoot(double num)
    {
        if (num < 0)
        {
            throw new ArgumentException("Unable to calculate square root of a negative number");
        }

        double result = num;
        result = (result + num / result) / 2;
        return result;
    }
    static void Main(string[] args)
    {
        double rootResult = RootOfNumber.SquareRoot(25);
        Console.WriteLine($"Square root of 25: {rootResult}");
    }
}


 